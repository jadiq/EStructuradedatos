//using System;
//// EJERCICIO1
//class Arquitecto
//{
//    private int codigo;
//    private string nombres;
//    private string condicionContrato;
//    private string especialidad;
//    private string tipoActividad;
//    private string tipoAfiliacion;

//    public Arquitecto(int codigo, string nombres, string condicionContrato, string especialidad, string tipoActividad, string tipoAfiliacion)
//    {
//        this.codigo = codigo;
//        this.nombres = nombres;
//        this.condicionContrato = condicionContrato;
//        this.especialidad = especialidad;
//        this.tipoActividad = tipoActividad;
//        this.tipoAfiliacion = tipoAfiliacion;
//    }

//    public double SueldoBase
//    {
//        get
//        {
//            if (condicionContrato == "Estable")
//            {
//                if (tipoActividad == "Supervisión de Obras")
//                {
//                    return 4000;
//                }
//                else if (tipoActividad == "Supervisión de Vías")
//                {
//                    return 6000;
//                }
//                else
//                {
//                    throw new Exception("Tipo de actividad no válido");
//                }
//            }
//            else if (condicionContrato == "Contratado")
//            {
//                if (tipoActividad == "Supervisión de Obras")
//                {
//                    return 2000;
//                }
//                else if (tipoActividad == "Supervisión de Vías")
//                {
//                    return 4500;
//                }
//                else
//                {
//                    throw new Exception("Tipo de actividad no válido");
//                }
//            }
//            else
//            {
//                throw new Exception("Condición de contrato no válida");
//            }
//        }
//    }

//    public double Bonificacion
//    {
//        get
//        {
//            if (especialidad == "Estructuras")
//            {
//                return SueldoBase * 0.16;
//            }
//            else if (especialidad == "Recursos Hídricos")
//            {
//                return SueldoBase * 0.18;
//            }
//            else
//            {
//                throw new Exception("Especialidad no válida");
//            }
//        }
//    }

//    public double Descuentos
//    {
//        get
//        {
//            return (SueldoBase + Bonificacion) * (0.15 + 0.08);
//        }
//    }

//    public double SueldoNeto
//    {
//        get
//        {
//            return (SueldoBase + Bonificacion) - Descuentos;
//        }
//    }

//    public double SueldoBruto
//    {
//        get
//        {
//            return SueldoBase + Bonificacion;
//        }
//    }

//    public void MostrarInformacion()
//    {
//        Console.WriteLine("Código: " + codigo);
//        Console.WriteLine("Nombres: " + nombres);
//        Console.WriteLine("Condición de contrato: " + condicionContrato);
//        Console.WriteLine("Especialidad: " + especialidad);
//        Console.WriteLine("Tipo de actividad: " + tipoActividad);
//        Console.WriteLine("Tipo de afiliación: " + tipoAfiliacion);
//        Console.WriteLine("Sueldo base: " + SueldoBase);
//        Console.WriteLine("Bonificación: " + Bonificacion);
//        Console.WriteLine("Descuentos: " + Descuentos);
//        Console.WriteLine("Sueldo neto: " + SueldoNeto);
//        Console.WriteLine("Sueldo bruto: " + SueldoBruto);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Arquitecto arquitecto = new Arquitecto(1, "Juan Pérez", "Estable", "Estructuras", "Supervisión de Obras", "AFP");

//        arquitecto.MostrarInformacion();

//        Console.WriteLine("Presione cualquier tecla para continuar...");
//        Console.ReadKey();
//    }
//}

using System;

class Jefe
{
    private string nombres;
    private string DNI;
    private string cargo;
    private string area;
    private int antiguedad;

    public Jefe(string nombres, string DNI, string cargo, string area, int antiguedad)
    {
        this.nombres = nombres;
        this.DNI = DNI;
        this.cargo = cargo;
        this.area = area;
        this.antiguedad = antiguedad;
    }

    public double SueldoBase
    {
        get
        {
            if (cargo == "Gerente")
            {
                if (area == "Contabilidad")
                {
                    return 6000;
                }
                else if (area == "Planificación")
                {
                    return 7000;
                }
                else
                {
                    throw new Exception("Área no válida");
                }
            }
            else if (cargo == "Subgerente")
            {
                if (area == "Contabilidad")
                {
                    return 5000;
                }
                else if (area == "Planificación")
                {
                    return 6000;
                }
                else
                {
                    throw new Exception("Área no válida");
                }
            }
            else
            {
                throw new Exception("Cargo no válido");
            }
        }
    }

    public double Movilidad
    {
        get
        {
            if (cargo == "Subgerente")
            {
                return 700;
            }
            else if (cargo == "Gerente")
            {
                return 400;
            }
            else
            {
                throw new Exception("Cargo no válido");
            }
        }
    }

    public double Bonificacion
    {
        get
        {
            if (antiguedad <= 7)
            {
                return SueldoBase * 0.05;
            }
            else if (antiguedad >= 8)
            {
                return SueldoBase * 0.04;
            }
            else
            {
                throw new Exception("Antigüedad no válida");
            }
        }
    }

    public double SueldoNeto
    {
        get
        {
            return SueldoBase + Bonificacion + Movilidad;
        }
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombres: " + nombres);
        Console.WriteLine("DNI: " + DNI);
        Console.WriteLine("Cargo: " + cargo);
        Console.WriteLine("Área: " + area);
        Console.WriteLine("Antigüedad: " + antiguedad);
        Console.WriteLine("Sueldo base: " + SueldoBase);
        Console.WriteLine("Movilidad: " + Movilidad);
        Console.WriteLine("Bonificación: " + Bonificacion);
        Console.WriteLine("Sueldo neto: " + SueldoNeto);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Jefe jefe1 = new Jefe("Juan Pérez", "123456789", "Gerente", "Contabilidad", 10);
        Jefe jefe2 = new Jefe("María López", "987654321", "Subgerente", "Planificación", 5);

        Console.WriteLine("Información del jefe 1:");
        jefe1.MostrarInformacion();

        Console.WriteLine("\nInformación del jefe 2:");
        jefe2.MostrarInformacion();

        Console.WriteLine("\nPresione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}





