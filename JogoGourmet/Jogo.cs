using JogoGourmet.Helpers;
using JogoGourmet.Models;
using System.IO;
using System.Security.AccessControl;

namespace JogoGourmet
{
    public partial class Jogo : Form
    {

        private List<Prato> _pratos;

        public Jogo()
        {
            InitializeComponent();
            lblMensagem.Text = "Pense em um prato que gosta";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ExibeCena();
        }

        private void ExibeCena()
        {
            _pratos = new List<Prato>();
            var pergunta = "O prato que você pensou é massa?";
            var resposta = MessageBox.Show(
                pergunta,
                "Confirma",
                MessageBoxButtons.YesNo);
            do
            {
                if (resposta.Equals(DialogResult.Yes))
                {
                    IncluiCena("Lasanha", true);
                }
                else
                {
                    if (_pratos.Count < 1)
                    {
                        IncluiCena("Bolo de chocolate");
                    }
                    else
                    {
                        AlteraCena();
                    }
                }

                foreach (var prato in _pratos.OrderByDescending(e => e.Ix))
                {
                    pergunta = $"O prato que você pensou é {prato.Nome}?";
                    resposta = MessageBox.Show(
                        pergunta,
                        "Confirma",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (resposta.Equals(DialogResult.Yes))
                    {
                        resposta = MessageBox.Show(
                            "Acertei de novo!",
                            "Jogo Gourmet",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        return;
                    }
                }


            } while (resposta != DialogResult.Yes);
        }

        private void IncluiCena(string nome, bool eMassa = false)
        {
            _pratos.Add(new Prato
            {
                Ix = _pratos.Count + 1,
                Nome = nome,
                Massa = eMassa
            });
        }

        private void AlteraCena()
        {
            var pratoNome = DialogoHelper.Exibe("Qual prato você pensou?", "Desisto");
            var pergunta = $"{pratoNome} é ______ mas {_pratos?.Last().Nome} não.";
            pratoNome = DialogoHelper.Exibe(pergunta, "Desisto");
            IncluiCena(pratoNome);
            return;
        }
    }
}