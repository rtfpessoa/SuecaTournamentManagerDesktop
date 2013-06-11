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
using Iesi.Collections;

namespace SuecaTournamentManager.Domain
{
    /// <summary>
    /// Description of Team.
    /// </summary>
    public class Team
    {
        public Team()
        {
        }

        public virtual int Id { get; set; }
        public virtual ISet Elements { get; set; }
        public virtual Association Association { get; set; }
        public virtual ISet Tournaments { get; set; }
    }
}
