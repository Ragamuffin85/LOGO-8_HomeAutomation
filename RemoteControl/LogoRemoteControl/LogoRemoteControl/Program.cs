/*
 Very simple program to read from a 300/400 PLC via MPI adapter.
 This shall provide users with a simple starting point for their own
 applications.
 
 Part of Libnodave, a free communication libray for Siemens S7 200/300/400
  
 (C) Thomas Hergenhahn (thomas.hergenhahn@web.de) 2005

 Libnodave is free software; you can redistribute it and/or modify
 it under the terms of the GNU Library General Public License as published by
 the Free Software Foundation; either version 2, or (at your option)
 any later version.

 Libnodave is distributed in the hope that it will be useful,
 but WITHOUT ANY WARRANTY; without even the implied warranty of
 MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 GNU General Public License for more details.

 You should have received a copy of the GNU Library General Public License
 along with Libnodave; see the file COPYING.  If not, write to
 the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA.  
*/

using System;
using System.Linq;
using System.Windows.Forms;

class test
{
    [STAThread]
    public static int Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.Run(new LogoRemoteControl.LogoSimpleControl() );
        return 0;
    }
}

/*
Version 0.8.4.5    
07/10/09  	Added closeSocket()
*/

