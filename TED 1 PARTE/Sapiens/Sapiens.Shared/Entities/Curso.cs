using Sapiens.Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapiens.shared.Entities;

public class Curso {
    public string Nome { get; set; }

    public int? CargaHoraria { get; set; }

    public TipoCurso Tipo { get; set; }

    public Curso(string nome)
    {
        Nome = nome;
    }

    public override string ToString()
    {
        return Nome;
    }
}
