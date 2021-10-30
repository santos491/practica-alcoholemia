using System;

namespace AlcoholemiaAPI.Domain
{
    public class Bebida_Vermu : IConsumirAlcohol
    {
        private double _vasoBebida = 0.0;
        private double _Peso = 0.0;
        private double _TotalAlcohol = 0.0;
        private double _TotalAlcoholConsumido = 0.0;
        private double _TotalAlcoholSangre =0.0;
        private double _TotalMasaEtanol = 0.0;
        private double _TotalVolumen_Sangre_Peso =0.0;
        private double _TotalVolumen_Alcohol_Sangre= 0.0;
        public void Calcular(double vasoBebida, double Peso)
        {
            _vasoBebida = vasoBebida;
            _Peso = Peso;
        //1
            _TotalAlcohol =_vasoBebida * 70;
            _TotalAlcoholConsumido = _TotalAlcohol * 17/100;
        //2
        _TotalAlcoholSangre = _TotalAlcoholConsumido * 15/100;
        //3
        _TotalMasaEtanol = _TotalAlcoholSangre * 0.789 ;
        //4
        _TotalVolumen_Sangre_Peso = Peso * 8/100;
        //5
        _TotalVolumen_Alcohol_Sangre = _TotalMasaEtanol / _TotalVolumen_Sangre_Peso;

        }        
        public string RetornarResultado()
        {
            return $"Total Alcohol consumido= {_TotalAlcoholConsumido}ml etoh, Cantidad Alcohol en sangre= {_TotalAlcoholSangre}ml etoh, Masa de Etanol es = {_TotalMasaEtanol}g, Volumen en Sangre= {_TotalVolumen_Sangre_Peso}L, volumen de alcohol en la sangre (Alcoholemia) = {_TotalVolumen_Alcohol_Sangre}g/L, DE ACUERDO AL RESULTADO USTED PUEDE CONDUCIR = {_TotalVolumen_Alcohol_Sangre < 0.8}";

        }
    }      
}