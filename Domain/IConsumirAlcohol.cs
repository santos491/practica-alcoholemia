namespace AlcoholemiaAPI.Domain
{
    public interface IConsumirAlcohol
    {
         void Calcular(double vasoBebida, double Peso);
         string RetornarResultado();
    }
}