namespace Program06_MembrosEstaticos02
{
    internal class Calculadora
    {
        public double Pi = 3.14; // Atributo

        public double Circunferencia(double raio) // Método
        {
            return 2.0 * Pi * raio;
        }

        public double Volume(double raio) // Método
        {
            return 4.0 / 3.0 * Pi * raio;
        }
    }
}
