using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Form113.Models
{
    /// <summary>
    /// Gestion du fil d'Arianne sur les pages utilisateurs
    /// </summary>
    public class BreadCrumItem
    {
        public string Control;
        public string Name;
        public string Action;

        /// <summary>
        /// objet breadcrumb pour stocker l'historique de navigation des pages menant à l'actuelle. Tous sauf le dernier seront sous forme de lien dans la page web. Pour le dernier on renverra une action vide. pour home/index par exemple on ajoutera un new breadcrum("Accueil","Index","Home")
        /// </summary>
        /// <param name="name">nom affiché sur la page web</param>
        /// <param name="action">action du controleur</param>
        /// <param name="control">nom du controlleur</param>
        public BreadCrumItem(string name, string action, string control)
        {
            Name = name;
            Action = action;
            Control = control;
        }
    }
}