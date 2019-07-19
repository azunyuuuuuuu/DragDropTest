using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using DragDropTest.Data;
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

        public List<Node> Nodes { get; set; } = new List<Node>();

        protected override void OnInit()
        {
            var rand = new Random();
            Nodes.Add(new Node { Position = new Vector2(rand.Next() % 560, rand.Next() % 410) });
            Nodes.Add(new Node { Position = new Vector2(rand.Next() % 560, rand.Next() % 410) });
            Nodes.Add(new Node { Position = new Vector2(rand.Next() % 560, rand.Next() % 410) });
            Nodes.Add(new Node { Position = new Vector2(rand.Next() % 560, rand.Next() % 410) });
            Nodes.Add(new Node { Position = new Vector2(rand.Next() % 560, rand.Next() % 410) });
            Nodes.Add(new Node { Position = new Vector2(rand.Next() % 560, rand.Next() % 410) });
        }

        public Vector2 _dragpositionstart;

        public void DragStart(UIDragEventArgs e)
        {
            _dragpositionstart = new Vector2(e.ClientX, e.ClientY);
        }

        public void DragEnd(UIDragEventArgs e, Node node)
        {
            var newpos = new Vector2(e.ClientX, e.ClientY);

            var newvalue = newpos - _dragpositionstart;
            node.Position += newvalue;
        }

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
