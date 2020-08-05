using MallFormulär.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MallFormulär.Components
{
    public partial class MallTabell<TData> where TData : Bas, new()
    {
        [Parameter] public RenderFragment ExtraRubriker { get; set; }
        [Parameter] public RenderFragment<TData> ExtraKolumner { get; set; }
        [Parameter] public IEnumerable<TData> Data { get; set; }
    }
}
