namespace Program07_MembrosEstaticos03
{
    internal class Calculadora
    {
        // STATIC PERMITE QUE OS MEMBROS POSSAM SER CHAMADOS SEM QUE SEJA NECEEÁRIO INSTANCIAR OBJETOS
        
        public static double Pi = 3.14; // Atributo

        public static double Circunferencia(double raio) // Método
        {
            return 2.0 * Pi * raio;
        }

        public static double Volume(double raio) // Método
        {
            return 4.0 / 3.0 * Pi * raio;
        }
    }
}
