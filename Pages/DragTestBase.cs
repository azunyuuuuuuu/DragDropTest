using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace DragDropTest.Pages
{
    public class DragTestBase : ComponentBase
    {

        public void Dragging(UIDragEventArgs e)
        {
            Console.WriteLine($"{e.Type} {e.ClientX} {e.ClientY} {e.ScreenX} {e.ScreenY}");
        }

        public bool Contexting(UIMouseEventArgs e)
        {
            Console.WriteLine($"Contexting");
            return false;
        }
    }
}
