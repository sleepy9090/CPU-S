/*
    File           ControlExtensions.cs
    Brief          Extension methods for working with controls.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/01/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Collections.Generic;
using System.Windows.Forms;

namespace CPU_S
{
    public static class ControlExtensions
    {
        public static IEnumerable<T> GetAllControlsOfType<T>(this Control root) where T : Control
        {
            foreach (Control child in root.Controls)
            {
                if (child is T targetType)
                {
                    yield return targetType;
                }

                if (child.HasChildren)
                {
                    foreach (var descendant in child.GetAllControlsOfType<T>())
                    {
                        yield return descendant;
                    }
                }
            }
        }
    }
}
