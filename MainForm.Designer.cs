/*
  * Sueca Tournament Manager - Simple Sueca tournament manager
  * Copyright (C) 2013  rtfpessoa
  *
  * Sueca Tournament Manager is free software: you can redistribute it and/or modify
  * it under the terms of the GNU General Public License as published by
  * the Free Software Foundation, either version 3 of the License, or
  * (at your option) any later version.
  *
  * Sueca Tournament Manager is distributed in the hope that it will be useful,
  * but WITHOUT ANY WARRANTY; without even the implied warranty of
  * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  * GNU General Public License for more details.
  *
  * You should have received a copy of the GNU General Public License
  * along with Sueca Tournament Manager.  If not, see <http://www.gnu.org/licenses/>.
  *
  */
 
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SuecaTournamentManager
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(282, 253);
			this.Name = "MainForm";
			this.Text = "SuecaTournamentManager";
			this.ResumeLayout(false);
		}
	}
}
