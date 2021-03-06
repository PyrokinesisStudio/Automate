﻿#region License Information (GPL v3)

/*
    Copyright (c) Jaex

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

namespace Automate
{
    public class Function_Call : Function
    {
        public override void Prepare()
        {
            int index;

            if (!int.TryParse(Parameters[0], out index))
            {
                index = FunctionManager.FindFunctionIndex(Parameters[0]);

                if (index > -1)
                {
                    Parameters[0] = (index + 1).ToString();
                }
            }
        }

        public override void Method()
        {
            int lineIndex;

            if (int.TryParse(Parameters[0], out lineIndex) && lineIndex > 0)
            {
                FunctionManager.Run(lineIndex);
            }
        }
    }
}