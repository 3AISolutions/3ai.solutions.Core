using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3ai.solutions.Core.Models
{
    public record Result
    {
        public bool Success { get; init; }
        public string? Message { get; init; }
        public string? LongMessage { get; init; }
    }
}
