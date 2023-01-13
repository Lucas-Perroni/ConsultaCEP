using ConsultaCEP.Services;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConsultaCEP.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void MetodoPesquisaCEP(object sender, EventArgs e)
        {
            PesquisarCEP pesquisaCEP = new PesquisarCEP();

            ViaCEP oViacep = new ViaCEP();
            oViacep = pesquisaCEP.Consulta(TextCep.Text);

            lbl_Cep.Text = oViacep.cep;
            lbl_logradouro.Text = oViacep.logradouro;
            lbl_complemento.Text = oViacep.complemento;
            lbl_bairro.Text = oViacep.bairro;
            lbl_localidade.Text = oViacep.localidade;
            lbl_uf.Text = oViacep.uf;
            lbl_ibge.Text = oViacep.ibge;
            lbl_gia.Text = oViacep.gia;
            lbl_ddd.Text = oViacep.ddd;
            lbl_siafi.Text = oViacep.siafi;
        }
    }
}