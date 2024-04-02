using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoGourmet.Helpers
{
    internal static class DialogoHelper
    {
        public static string Exibe(string texto, string titulo)
        {
            Form frmDialogo = new Form()
            {
                Text = titulo,
                Width = 500,
                Height = 200,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                MaximizeBox = false,
                MinimizeBox = false,
            };
            
            var lblTexto = new Label() 
            {                
                Left = 50, 
                Top = 20,
                Width = 400,
                Text = texto
            };
            
            var txtResposta = new TextBox() 
            { 
                Left = 50, 
                Top = 50, 
                Width = 400 
            };
            
            var btnOk = new Button() 
            { 
                Text = "Ok", 
                Left = 130, 
                Width = 100, 
                Height = 30,
                Top = 90, 
                DialogResult = DialogResult.OK 
            };
            
            var btnCancelar = new Button()
            {
                Text = "Cancelar",
                Left = 280,
                Width = 100,
                Height = 30,
                Top = 90,
                DialogResult = DialogResult.Cancel
            };

            btnOk.Click += (sender, e) => 
            {
                frmDialogo.Close(); 
            };

            btnCancelar.Click += (sender, e) =>
            {
                frmDialogo.Close();
            };

            frmDialogo.Controls.Add(lblTexto);
            frmDialogo.Controls.Add(txtResposta);
            frmDialogo.Controls.Add(btnOk);
            frmDialogo.Controls.Add(btnCancelar);
            frmDialogo.AcceptButton = btnOk;
            frmDialogo.CancelButton = btnCancelar;

            return frmDialogo.ShowDialog() == DialogResult.OK ? txtResposta.Text : "";
        }
    }
}
