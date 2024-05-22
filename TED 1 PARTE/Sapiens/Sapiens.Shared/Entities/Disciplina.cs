using Sapiens.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapiens.shared.Entities;

public class Disciplina
{
    [StringLength(100)]
    public required string Nome { get; set; }

    public TipoDisciplina Tipo { get; set; }
}
