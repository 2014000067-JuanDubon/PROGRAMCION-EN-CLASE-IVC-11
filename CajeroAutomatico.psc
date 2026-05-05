Algoritmo CajeroAutomatico
	Definir saldo, deposito, retiro Como Real
	Definir opcion, intentos Como Entero
	Definir pin, pinCorrecto Como Entero
	
	saldo=10000
	pinCorrecto=1234
	intentos=0
	
	Mientras intentos<3 Hacer
		Escribir Sin Saltar "Ingrese su pin: "
		leer pin
		Si pin == pinCorrecto Entonces
			Limpiar Pantalla
			Escribir "¡¡¡Acceso Consedido!!!"
			
			Repetir
				Limpiar Pantalla
				Escribir "=========================="
				Escribir "      MENÚ PRINCIPAL      "
				Escribir "1- Consultar Saldo"
				Escribir "2- Depositar Dinero"
				Escribir "3- Retirar Dinero"
				Escribir "4- Salir"
				Escribir "=========================="
				
				Escribir Sin Saltar "Seleccione una opcion:  () "
				leer opcion
				
				Segun opcion Hacer
					1:
						Limpiar Pantalla
						Escribir "Su saldo actual es: Q.",saldo
						Escribir "Presione una tecla para volver al menu"
						Esperar Tecla
					2:
						Limpiar Pantalla
						Escribir Sin Saltar "Ingrese el monto a depositar Q."
						Leer deposito
						saldo=saldo+deposito
						Escribir "Deposito exitoso, saldo nuevo: Q.",saldo
						Escribir "Presione una tecla para volver al menu"
						Esperar Tecla
					3:
						Limpiar Pantalla
						Escribir Sin Saltar "Ingrese el monto a retirar: 	Q."
						leer retiro
						
						si retiro <= saldo Entonces
							saldo=saldo-retiro
							Escribir "Retiro Exitoso, nuevo saldo Q.",saldo
						SiNo
							Escribir "Fondos insuficientes"
						FinSi
						Escribir "Presione una tecla para volver al menu"
						Esperar Tecla
					4:
						Limpiar Pantalla
						Escribir "Gracias por usar el Cajero"
					De Otro Modo:
						Escribir "Opcion Invalida"
				Fin Segun
			Hasta Que opcion ==4
			intentos=5
			
			
			
		SiNo
			intentos=intentos+1
			Escribir "Pin incorrecto, intentos", intentos,"de 3"
		Fin Si
	Fin Mientras
	
	
	Si intentos==3 Entonces
		Escribir "Tarjeta Bloqueada"
		Escribir "Demasiados intentos fallidos"
		
		
	Fin Si
	
	Si intentos==5 Entonces
		Escribir ()
	Fin Si
	Escribir "Presione una tecla para salir"
	Esperar Tecla
FinAlgoritmo
