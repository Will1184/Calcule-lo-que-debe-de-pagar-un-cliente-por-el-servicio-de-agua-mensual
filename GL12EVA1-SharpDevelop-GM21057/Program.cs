/*
 * Creado por SharpDevelop.
 * Usuario: BRANDON
 * Fecha: 5/4/2022
 * Hora: 9:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
// Evaluacion: 1
// Clave:1
// Fecha: 5/4/2022
// Autor: Brandon William Gomez Monge
// Carnet: GM21057
// GD: #12
// Instructora: Lizeth Carmeline Gochez De Peñate

namespace GL12EVA1_SharpDevelop_GM21057
{
	//Descripcion del programa:
	//Calcule lo que debe de pagar un cliente por el servicio de agua mensual, dependiendo del tipo de cliente.Los clientes empresariales que excedan su consumo de 120 m3 al mes tendrán un recargo del 1.5% Debe de mostrar en pantalla: el nombre del cliente, el tipo y el total a pagar en la factura

	class Program
	{
		const double CLIENTE_DOMICILIAR=0.309;
		const double CLIENTE_EMPRESARIAL=1.220;
		const double CLIENTE_PREFERENCIAL=0.619;
		const double RECARGO_EXCENDENTE=0.015;
		public static void Main(string[] args)
		{
	    //Identificacion del programa en pantalla
		Console.Title=("Calcular lo que el cliente debe pagar por el servicio de agua ");
		Console.WriteLine("Calcular lo que el cliente debe pagar por el servicio de agua ");
		Console.WriteLine("Autor:Brandon Gomez");
	    
	    
		//DECLARACION DE VARIABLES
		string nombreCliente;
		double tipoCliente,totalPagar,consumoMensual;
		//ENTRADA DE DATOS
		Console.Write("Ingrese nombre: "); nombreCliente=Console.ReadLine();
		Console.WriteLine("Ingrese tipo de cliente [Presione 1 para: Domiciliar; Presione 2 para: Empresarial; Presione 3 para: Preferencial;]: "); tipoCliente=double.Parse(Console.ReadLine());
		Console.Write("Ingrese el consumo de m3 de agua en el mes: "); consumoMensual=double.Parse(Console.ReadLine());
		//PROCESO DE DATOS
        totalPagar= leerConsumoCliente(tipoCliente,consumoMensual);
		
		//SALIDA DE DATOS
		Console.WriteLine("Nombre del cliente: "+ nombreCliente );
		Console.WriteLine("Tipo de cliente [1=Domiciliar; 2=Empresarial; 3=Preferencial]: "+ tipoCliente );
		Console.WriteLine("Total a pagar:$ "+totalPagar  );
		
		Console.ReadKey();
		}
		
		//Contiene el proceso de calculo para obtener el total a pagar
		static double leerConsumoCliente(double tipoCliente, double consumoMensual)
		{
			double totalPagar=0;
		if (tipoCliente==1) {
			totalPagar=consumoMensual*CLIENTE_DOMICILIAR;
			return totalPagar;
			}
			
		if (tipoCliente==2) {
			if (consumoMensual>120) {totalPagar=(consumoMensual*CLIENTE_EMPRESARIAL)*RECARGO_EXCENDENTE; return totalPagar;}
			//Los clientes empresariales que excedan su consumo de 120 m3 al mes tendrán un recargo del 1.5%
			else totalPagar=consumoMensual*CLIENTE_EMPRESARIAL; return totalPagar;	
		
			}
		
		if (tipoCliente==3) {
			totalPagar=consumoMensual*CLIENTE_PREFERENCIAL;	
		    return totalPagar;
			}
			return totalPagar;
		}
	}
}