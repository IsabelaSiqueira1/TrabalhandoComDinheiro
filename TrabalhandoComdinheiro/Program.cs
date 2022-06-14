using Caelum.Stella.CSharp.Vault;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoComdinheiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Utilizando o metodo Money da biblioteca caelum csharp
            //é possivel transformar qualquer favor a moeda real sem precisar formatar
            Money money = 10.00;
            Debug.WriteLine(money); 

            double valor1 = 10.00;
            double valor2 = 20.00;
            Money total = valor1 + valor2;
            Debug.WriteLine(total);


            decimal minuedo = 20m;
            decimal subtraendo = 15m;
            Money diferenca = minuedo - subtraendo;
            Debug.WriteLine(diferenca);

            //Caso precise trabalhar com outro tipo de moeda
            //Currency é um enumerador que irá informar o tipo da moeda (BRL, EUR, USD)

            Money euro = new Money(Currency.EUR, 1000);
            Debug.WriteLine(euro);

            Money dolar = new Money(Currency.USD, 1000);
            Debug.WriteLine(dolar);

            //formatando a thread para o valor americano
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            Debug.WriteLine(dolar);

            //não é possivel fazer operações entre moedas diferentes, primeiro precisa fazer a conversão para a mesma moeda.
            //o programa deve retornar uma exceção.
            Money somaMoedasDiferentes = euro + dolar;
            Debug.WriteLine(somaMoedasDiferentes);
        }
    }
}
