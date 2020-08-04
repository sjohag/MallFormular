using MallFormulär.DTO;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MallFormulär.Components
{
    public partial class MallFormulär<TData> where TData : Bas, new()
    {
        [Parameter] public EventCallback<TData> FormulärSparat { get; set; }
        [Parameter] public RenderFragment<TData> ChildContent { get; set; }
        private TData Data { get; set; }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            Data = new TData();
        }
        private async Task Sparat()
        {
            await FormulärSparat.InvokeAsync(Data);
        }
    }
}
