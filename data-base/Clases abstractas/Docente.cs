/***********************************************************************
 * Module:  Docente.cs
 * Author:  Kalia
 * Purpose: Definition of the Class Docente
 ***********************************************************************/

using System;

public class Docente : Persona, ICalculos
{
   public void IMostrar(DataGridView grilla)
   {
      // TODO: implement
   }

   private double CalcularIESS()
   {
      // TODO: implement
      return 0.0;
   }
   
   private double CalcularSueldo()
   {
      // TODO: implement
      return 0.0;
   }

   private String Titulo;
   private double Sueldo;

}