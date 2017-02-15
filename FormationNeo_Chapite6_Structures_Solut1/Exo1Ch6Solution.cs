﻿
/* Vous revoila! Vous devez avoir lu "FormationNeo_Chapitre6_Structures_Tuto"...
 * Si ce n'est pas fait, cliquer dans l'onglet de droite "Explorateur de solution" sur le projet qui 
 * s'appel "FormationNeo_Chapitre5_Variable_Tuto". Dans le menu déroulant qui s'affiche, et double cliquer 
 * sur le fichier "Program.cs" pour continuer votre formation.
 * 
 * Nous allons commencer par les structures conditionelles (if, if/else if)
 * Les notions dont vous avez besoin sont:
 *      --> Les variables
 *      --> Le 'if / else if / else'
 *      --> le switch
 *      --> La logique de Boole
 * 
 * Commencer par choisir ce projet au démarrage. pour ce faire, faites un clic droit sur "FormationNeo_Chapitre6_Structures_Solut1",
 * et cliquer sur l'icone de roue dentée "Définir comme projet de démarrage"
 * 
 * Utiliser Ctrl + F5 pour compiler et lancer le projet
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationNeo_Chapite6_Structures_Exo1
{
    class Exo1Ch6
    {
        /* Nous allons créer un système d'identification pour savoir qui aura accès au QG des
         * super-héros, et pour cela nous allons tester notre système de défense.
         * C'est parti!
        */

        static void Main(string[] args)
        {
            // A vous de déclarer et de modifier les variables comme il vous plaira!
            bool hero = true;
            bool superhero = true;

            // Ce système est défaillante, il laisse rentrer n'importe qui!
            // Appliquer une modification pour que seul un héro puisse passer!
            if (hero)
            {
                Console.WriteLine("Bonjour héro!"); // si "hero == true"
            }
            else
            {
                Console.WriteLine("Seul un héro peut passer!"); // si "hero == false"
            }


            // La salle de controle possède le même système, mais plus complexe
            // Si les héros ont accès au batiment, seul un vrai superhéro doit avoir accès à
            // la salle de controle! Modifier ce code pour que cela soit exacte
            // On considère qu'un superhéro est un héro
            if (hero || superhero) // si "hero == true" ou "superhero == true"
            {
                // Encore une fois, seul un héro ou un superhéro doit pouvoir voir cette ligne
                Console.WriteLine("Bienvenue dans le QG, héro!");
                if (superhero) // si "superhero == true"
                {
                    // Seul un superhéro doit voir cette ligne
                    Console.WriteLine("Bienvenue dans la salle de controle, superhéro!");
                }
                else // si "superhero == false"
                {
                    // Cette ligne doit être afficher aux héros, mais ni au super héro, ni aux 'non héro'
                    Console.WriteLine("Désolé, salle réservé au super héros!");
                }
            }

            // Tout les jours, des centaines de nouvelles personnes tentent d'être accepté chez les superhéros!
            // Ces personnes sont évalués sur 3 critères : puissace, intelligence et vitesse, comprises entre 0 et 100
            // Si une personne à toutes ces valeurs en dessous de 40, c'est un civil.
            // Si une personne n'as qu'un critère au dessus de 50, et que la somme de ces compétances est égale ou supérieure à 100, c'est un héro
            // Si toutes les valeurs sont supérieurs à 60, alors c'est un super héro
            // Enfin, si une des valeurs est égal à 100 et que la somme des critères est supérieur à 260, c'est surement Superman!
            // Tout les autres sont des civils!
            //
            // A vous d'écrire un code permettant de tester la valeur des nouvelles recrues!
            // Indice : Allez y pas à pas!
            // Pas besoin de dire à Superman que c'est un superhéro ni un héro...
            // Pas besoin de dire à un superhéro que c'est un héro non plus!
            int puissance = 90;
            int intelligence = 90;
            int vitesse = 100;

            // Ces tests ont été mis sur plusieurs ligne pour plus de visibilité
            if ((puissance + intelligence + vitesse >= 260) &&
               ((puissance == 100) || (intelligence == 100) || (vitesse == 100)))
            {
                Console.WriteLine("Vous êtes Superman!!!!!");
            }
            else if ((puissance > 60) && (intelligence > 60) && (vitesse > 60))
            {
                Console.WriteLine("Vous êtes un Superhéros!");
            }
            else if ((puissance + intelligence + vitesse >= 100) &&
                    ((puissance > 50) || (intelligence > 50) || (vitesse > 50)))
            {
                Console.WriteLine("Vous êtes un Héro!");
            }
            else
            {
                // Pas besoin de tester autre chose! En effet, si vous n'êtes pas dans un de ces cas, vous êtes un civil!
                // (puissance < 40) && (intelligence < 40) && (vitesse < 40) est toujours vrai!
                Console.WriteLine("Vous êtes un civil...");
            }
        }
    }
}