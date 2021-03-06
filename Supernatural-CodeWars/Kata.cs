﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supernatural_CodeWars
{
    public static class Kata
    {
        public static string Bob(string monsterName)
        {
            string reply = "";

            switch (monsterName)
            {
                case "werewolf":
                    reply = "Silver knife or bullet to the heart";
                    break;
                case "vampire":
                    reply = "Behead it with a machete";
                    break;
                case "wendigo":
                    reply = "Burn it to death";
                    break;
                case "shapeshifter":
                    reply = "Silver knife or bullet to the heart";
                    break;
                case "angel":
                    reply = "Use the angelic blade";
                    break;
                case "demon":
                    reply = "Use Ruby's knife, or some Jesus-juice";
                    break;
                case "ghost": 
                    reply = "Salt and iron, and don't forget to burn the corpse";
                    break;
                case "dragon":
                    reply = "You have to find the excalibur for that";
                    break;
                case "djinn":
                    reply = "Stab it with silver knife dipped in a lamb's blood";
                    break;
                case "pagan god":
                    reply = "It depends on which one it is";
                    break;
                case "leviathan":
                    reply = "Use some Borax, then kill Dick";
                    break;
                case "ghoul":
                    reply = "Behead it";
                    break;
                case "jefferson starship":
                    reply = "Behead it with a silver blade";
                    break;
                case "reaper":
                    reply = "If it's nasty, you should gank who controls it";
                    break;
                case "rugaru":
                    reply = "Burn it alive";
                    break;
                case "skinwalker":
                    reply = "A silver bullet will do it";
                    break;
                case "phoenix":
                    reply = "Use the colt";
                    break;
                case "witch":
                    reply = "They are humans";
                    break;
                default:
                    reply = "I have friggin no idea yet";
                    break;
            }

            return reply + ", idjits!";
        }
    }
}


//Those wayward Winchester boys are in trouble again, hunting something down in New Orleans. You are Bobby Singer, you know how "idjits" they can be, so you have to prepare. They will call you any minute with the race of the thing, and you want to answer as soon as possible. By answer, I mean: tell them how to kill, or fight it.

//You have something like a database (more like drunken doodling) to help them:

//werewolf : Silver knife or bullet to the heart
//vampire : Behead it with a machete
//wendigo : Burn it to death
//shapeshifter : Silver knife or bullet to the heart
//angel : Use the angelic blade
//demon : Use Ruby's knife, or some Jesus-juice
//ghost : Salt and iron, and don't forget to burn the corpse
//dragon : You have to find the excalibur for that
//djinn : Stab it with silver knife dipped in a lamb's blood
//pagan god : It depends on which one it is
//leviathan : Use some Borax, then kill Dick
//ghoul : Behead it
//jefferson starship : Behead it with a silver blade
//reaper : If it's nasty, you should gank who controls it
//rugaru : Burn it alive
//skinwalker : A silver bullet will do it
//phoenix : Use the colt
//witch : They are humans
//else : I have friggin no idea yet
//So a call would go down like this:

//The guys call you: bob('rugaru')

//...and you reply (return) with the info, and your signature saying of yours! Burn it alive, idjits!

//You now have a preloaded const drunkenDoodling, say thanks to ccrisis for it! :)