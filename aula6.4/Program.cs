﻿namespace aula6._4
{
    internal class Program
    {
        static void Main(){

            double valorCompra = 5.50;
            double valorVenda;
            double lucro=0.1;
            string produto = "Pastel";

            valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("Produto........:{0,15}", produto);
            Console.WriteLine("Val.compra........:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro........:{0,15:p}", lucro);
        }
    }
}