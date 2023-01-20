using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorDadesJson
{
    public partial class Form1 : Form
    {
        public List<persona> listaPersonas;
        public List<persona> listaPersonasFiltradas;
        
        public string json_readed = string.Empty;

        public string timeSeq = string.Empty;
        public string timeLinq = string.Empty;

        public Boolean canPocessData = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e){
            cb_modoUso.SelectedItem = "SEQUENCIAL";
            cb_eliminacio.SelectedItem = "ELIMINAR INVALIDOS";

            dgrid_datos.AutoGenerateColumns = false;
            dgrid_datos.Columns.Add("Name", "Nombre");
            dgrid_datos.Columns.Add("Surname", "Apellido");
            dgrid_datos.Columns.Add("Gender", "Direccion");
            dgrid_datos.Columns.Add("Company", "Email");
            dgrid_datos.Columns.Add("Email", "Telefono");
            dgrid_datos.Columns.Add("Country", "País");
            dgrid_datos.Columns.Add("Dni", "Dni");
        }

        private Task ObtenerDatosJSON()
        {
            listaPersonas = new List<persona>();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos json (*.json)|*.json|Archivos de texto (*.txt)|*.txt";
            if (DialogResult.OK == dialog.ShowDialog())
            {
                tb_pathFile.Text = dialog.FileName;
                if (File.Exists(dialog.FileName))
                {
                    string json = File.ReadAllText(dialog.FileName);
                    listaPersonas = JsonConvert.DeserializeObject<List<persona>>(json);
                    foreach (persona personas in listaPersonas)
                    {
                        dgrid_datos.Rows.Add(
                            personas.Name,
                            personas.Surname,
                            personas.Gender,
                            personas.Company,
                            personas.Email,
                            personas.Country,
                            personas.Dni
                            );

                    }
                    canPocessData = true;
                }
                dialog.Dispose();
            }
            label_total_personas.Text = listaPersonas.Count.ToString();
            label_num_validas.Text = "?/"+listaPersonas.Count.ToString();
            label_num_invalidas.Text = "?/" + listaPersonas.Count.ToString();

            return Task.CompletedTask;
        }

        /*
         * LINQ
         */
        public async Task<List<persona>> ValidatePersonDataLinq(List<persona> personList)
        {
             List<persona> result = personList.Where(persona => persona.comprova_dni() && persona.comprova_nom() && persona.comprova_mail()).ToList();
            return await Task.FromResult(result);
        }
        public async Task<List<persona>> InvalidPersonDataLinq(List<persona> personList)
        {
            List<persona> result = personList.Where(persona => !persona.comprova_dni() || !persona.comprova_nom() || !persona.comprova_mail()).ToList();
            return await Task.FromResult(result);
        }

        /*
         * SEQUENCIAL
         */
        public Task<List<persona>> ValidatePersonDataSeq(List<persona> personList)
        {
            List<persona> validPersons = new List<persona>();
            foreach (persona persona in personList)
            {
                if (persona.comprova_dni() && persona.comprova_nom() && persona.comprova_mail())
                {
                    validPersons.Add(persona);
                }
            }
            return Task.FromResult(validPersons);
        }

        public Task<List<persona>> InvalidPersonDataSeq(List<persona> personList)
        {
            List<persona> invalidPersons = new List<persona>();
            foreach (persona persona in personList)
            {
                if (!persona.comprova_dni() || !persona.comprova_nom() || !persona.comprova_mail())
                {
                    invalidPersons.Add(persona);
                }
            }
            return Task.FromResult(invalidPersons);

        }


        public async Task<List<persona>> InValidPerson(string RunMode, List<persona> personas)
        {
            List<persona> persones_invalides = new List<persona>();
            if (RunMode == "SEQUENCIAL")
            {
                persones_invalides = await InvalidPersonDataSeq(personas);
            }
            else
            {
                persones_invalides = await InvalidPersonDataLinq(personas);
            }

            int num_personas = listaPersonas.Count;
            int num_invalidas = persones_invalides.Count;
            int num_validas = (num_personas - num_invalidas);

            label_num_validas.Text = num_validas + "/" + num_personas;
            label_num_invalidas.Text = num_invalidas + "/" + num_personas;

            return persones_invalides;
        }

        public async Task<List<persona>> ValidPerson(string RunMode, List<persona> personas)
        {
            List<persona> persones_valides = new List<persona>();
            if (RunMode == "SEQUENCIAL")
            {
                persones_valides = await ValidatePersonDataSeq(personas);
            }
            else
            {
                persones_valides = await ValidatePersonDataLinq(personas);
            }
            
            int num_personas = listaPersonas.Count;
            int num_validas = persones_valides.Count;
            int num_invalidas = (num_personas - num_validas);
            
            label_num_validas.Text = num_validas + "/" + num_personas;
            label_num_invalidas.Text = num_invalidas + "/" + num_personas;
            
            return persones_valides;
        }

        public async void buttonInsertDataFromFile(object sender, EventArgs e)
        {
            await ObtenerDatosJSON();
            // DESHABILITADO DEBIDO A QUE USA SUBPROCESSOS Y NO SE PUEDE
            // ACCEDER A DGIRD_DATOS SINO ES EL HILO PRINCIPAL
            //
            //    Parallel.ForEach(listaPersonas, personas =>
            //    {
            //        dgrid_datos.Rows.Add(
            //            personas.Name,
            //            personas.Surname,
            //            personas.Gender,
            //            personas.Company,
            //            personas.Email,
            //            personas.Country,
            //            personas.Dni
            //            );
            //    });
        }

        private async void buttonFilterDataFromFilter(object sender, EventArgs e)
        {

            if (canPocessData)
            {
                listaPersonasFiltradas = new List<persona>();
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                if (cb_eliminacio.Text == "ELIMINAR INVALIDOS")
                {
                    listaPersonasFiltradas = await ValidPerson(cb_modoUso.Text, listaPersonas);
                }
                else
                {
                    listaPersonasFiltradas = await InValidPerson(cb_modoUso.Text, listaPersonas);

                }
                dgrid_datos.Rows.Clear();
                dgrid_datos.DataSource = null;
                foreach (persona personas in listaPersonasFiltradas)
                {
                    dgrid_datos.Rows.Add(
                        personas.Name,
                        personas.Surname,
                        personas.Gender,
                        personas.Company,
                        personas.Email,
                        personas.Country,
                        personas.Dni
                        );

                }
                stopwatch.Stop();
                float segundos = stopwatch.ElapsedMilliseconds / 1000;
                if (cb_modoUso.Text == "SEQUENCIAL")
                {
                    tb_seq.Text = segundos.ToString();
                }
                else
                {
                    tb_linq.Text = segundos.ToString();
                }
                
            }


        }
    }
}
