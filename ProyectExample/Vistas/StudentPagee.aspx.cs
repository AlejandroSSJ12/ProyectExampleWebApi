using HTTPupt;
using ProyectExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectExample.Vistas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:50942");
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultStudents();
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            
            var age = Int32.Parse(setAge.Text);
            studentt Students = new studentt
            {
                Name = setName.Text,
                Age = age
            };
            String json = JsonConvertidor.Objeto_Json(Students);
            peticion.PedirComunicacion("StudentT/Insert", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(json);
            json = peticion.ObtenerJson();
            comprobar.Text = json;
            ConsultStudents();
        }
        private void ConsultStudents()
        {
            peticion.PedirComunicacion("StudentT/ConsultStudents", MetodoHTTP.GET, TipoContenido.JSON);
            string json = peticion.ObtenerJson();
            List<studenttDTO> studentt = JsonConvertidor.Json_ListaObjeto<studenttDTO>(json);
            Gss.DataSource = studentt;
            Gss.DataBind();
        }
    }
}