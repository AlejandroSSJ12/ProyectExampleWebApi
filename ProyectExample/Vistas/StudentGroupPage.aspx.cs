using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HTTPupt;
using Microsoft.Win32;
using ProyectExample.Models;

namespace ProyectExample.Vistas
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        PeticionHTTP peticion = new PeticionHTTP("http://localhost:50942");
        protected void Page_Load(object sender, EventArgs e)
        {
            GS();
            
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            List<groupStudent> students = new List<groupStudent>();
            foreach (GridViewRow register in GVGS.Rows)
            {
                CheckBox seleccion = (CheckBox)register.FindControl("chbStudent");
                if (seleccion.Checked)
                {
                    groupStudent groupStudent = new groupStudent()
                    {
                        StudentId = int.Parse(register.Cells[1].Text),
                        GroupId = int.Parse(ddlGroup.SelectedValue)
                    };

                    students.Add(groupStudent);
                }
            }
                
                
            string json = JsonConvertidor.Objeto_Json(students);
            peticion.PedirComunicacion("StudentGroup/Insert", MetodoHTTP.POST, TipoContenido.JSON);
            peticion.enviarDatos(json);
            json = peticion.ObtenerJson();
            comprobar.Text = json;
            GS();

            


        }

        private void GS()
        {
            peticion.PedirComunicacion("StudentT/ConsultStudents", MetodoHTTP.GET, TipoContenido.JSON);
            string json = peticion.ObtenerJson();
            List<studenttDTO> student = JsonConvertidor.Json_ListaObjeto<studenttDTO>(json);
            GVGS.DataSource = student;
            GVGS.DataBind();
        }
    }
}
