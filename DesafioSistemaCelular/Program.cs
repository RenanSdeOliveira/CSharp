using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using DesafioSistemaCelular.Models;


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1123", modelo: "nokia 1", imei: "123124", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "4322", modelo: "iphone 2", imei: "44312", memoria: 16);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");