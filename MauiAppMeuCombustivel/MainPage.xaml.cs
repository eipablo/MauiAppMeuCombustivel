namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {

                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;
                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "Etanol é a melhor opção para o seu " + marca + " " + modelo;
                }
                else
                {
                    msg = "Gasolina é a melhor opção para o seu " + marca + " " + modelo;
                }

                DisplayAlert("Calculado", msg, "Ok");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            }
        } //fecha metodo
    } //fecha class

} //fecha main space
