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
    public partial class WebForm2 : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:50942");
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultStudents();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            group Groups = new group
            {
                Name = setGroup.Text
            };
            String json = JsonConvertidor.Objeto_Json(Groups);
            peticion.PedirComunicacion("Group/Insert", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(json);
            json = peticion.ObtenerJson();
            comprobar.Text = json;
            ConsultStudents();
        }

        private void ConsultStudents()
        {
            peticion.PedirComunicacion("Group/ConsultStudents", MetodoHTTP.GET, TipoContenido.JSON);
            string json = peticion.ObtenerJson();
            List<groupDTO> group = JsonConvertidor.Json_ListaObjeto<groupDTO>(json);
            Gs.DataSource = group;
            Gs.DataBind();
        }
    }
}