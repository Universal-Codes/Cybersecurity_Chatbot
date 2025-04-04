using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CybersecurityChatbot
{
    class CyberSecurityChatbot
    {

        //The beginning of the application        
        static void Main()
        {
            VoiceGreeting(); //Plays the voice greeting
            DisplayAscii(); //Displays the ASCII art
            StartChatbot(); //Starts the chatbot
        }
        static void VoiceGreeting()
        {
            string filePath = @"D:\ONE DRIVE\OneDrive\Desktop\School Material\PROG6221\CybersecurityChatbot\bin\Debug\Greeting.wav";

            Console.WriteLine("Looking for file at: " + filePath);

            
                try
                {
                    using (SoundPlayer voice = new SoundPlayer(@"D:\ONE DRIVE\OneDrive\Desktop\School Material\PROG6221\CybersecurityChatbot\bin\Debug\Greeting.wav"))
                    {
                        voice.Load();  // Ensure the file is loaded
                        voice.PlaySync(); // Play the audio synchronously
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] Audio could not be played.");
                }
            
            
        }


        // This will display ASCII art for visual appeal
        static void DisplayAscii()
        {
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine(@"  
               ██████╗          ███████╗   ██████╗ ████████╗
              ██╔════╝          ██╔═══██╗ ██╔═══██╗╚══██╔══╝
              ██║      ████ ║   ██║████ ║ ██║   ██║   ██║ 
              ██║    ╗          ██║   ██║ ██║   ██║   ██║   
              ╚██████║          ███████╔╝ ╚██████╔╝   ██║   
               ╚═════╝           ╚═════╝   ╚═════╝    ╚═╝   
     
  ");
            Thread.Sleep(1000); //This will pause the program for a sec for readability.
        }
        // Handles chatbot interactions
        static void StartChatbot()
        {
            Console.WriteLine("Hello. What's your name?\n");
            string name = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(name))
            {
                name="Guest";
            }
            Console.WriteLine($"Nice to meet you, {name}! I'm CyBot. The Cybersecurity Awareness Assistant. How can I help you today?");

            while (true)
            {
                Console.WriteLine("\n");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("What would you like to know today?");
                    continue;
                }

                if(input.Contains("exit") || input.Contains("quit"))
                {
                    Console.WriteLine("\nStay safe online. Remember, I am always here to assist. Goodbye!");
                    break;
                }
                Console.WriteLine($"{GetResponse(input)}");
            }
        }

        static string GetResponse(string input)
        {
            if (input.Contains("phishing")|| input.Contains("scam") 
                || input.Contains("Scam") || input.Contains("Phishing") 
                || input.Contains("Phising") || input.Contains("fishing")) 
                return "Phishing\r\n--------\r\n\r\nPhishing Scams: How to Spot & Avoid Them\r\nPhishing scams steal sensitive information through emails, texts, calls, and fake websites. Here’s how to recognize and avoid them:\r\n\r\n1. Email Phishing (Most Common)\r\nFake emails from trusted companies link to scam sites.\r\nAvoid: Check sender addresses, hover over links, and manually type URLs.\r\n\r\n2. Spear Phishing (Targeted Attack)\r\nAttackers impersonate someone you trust.\r\nAvoid: Verify unexpected requests via a known contact and limit personal info online.\r\n\r\n3. Smishing (SMS Phishing)\r\nTexts claim your account is locked or you won a prize.\r\nAvoid: Don’t click unknown links; contact your provider directly.\r\n\r\n4. Vishing (Voice Phishing)\r\nScammers pose as banks or tech support.\r\nAvoid: Hang up and call the official number; never share sensitive info.\r\n\r\n5. Clone Phishing\r\nA real email is copied but links are swapped with malicious ones.\r\nAvoid: Verify unexpected emails with the sender and scan attachments.\r\n\r\n6. Social Media Phishing\r\nFake messages or posts trick you into clicking malicious links.\r\nAvoid: Don’t accept unknown requests; enable privacy settings.\r\n\r\n7. Search Engine Phishing\r\nScam sites appear in search results.\r\nAvoid: Type official URLs, use ad blockers, and verify sites before entering info.\r\n\r\nGeneral Protection Tips:\r\nUse multi-factor authentication (MFA)\r\nInstall antivirus & anti-phishing tools\r\nUpdate passwords regularly\r\nNever share sensitive data unless verified\r\nReport phishing attempts\r\n\n. I hope the information provided is useful!";
           
            if (input.Contains("password") || input.Contains("Password") 
                || input.Contains("PIN") || input.Contains("pin") 
                || input.Contains("Pin")) 
                return "Password Security.\r\n------------------\r\n\r\nGolden Rule: If it feels urgent, too good to be true, or suspicious—STOP, THINK, VERIFY.\r\n\r\nPassword Usage & Creation\r\nStrong passwords protect your accounts from hackers. Here’s how to create and manage them:\r\n\r\nHow to Create a Strong Password:\r\n\r\n-> Use at least 8-16 characters (longer is better).\r\n\r\n-> Mix uppercase & lowercase letters, numbers, and symbols (e.g., P@ssw0rd!234).\r\n\r\nAvoid common words, birthdays, or pet names—hackers can guess these easily.\r\n\r\nDon’t reuse passwords for multiple accounts.\r\n\r\nBest Practices for Managing Passwords:\r\n\r\n-> Use a password manager to store and generate passwords securely.\r\n\r\n-> Enable multi-factor authentication (MFA) for extra security.\r\n\r\n-> Change passwords immediately if you suspect a breach.\r\n\r\nNever share your password with anyone—not even IT support!\r\n\nGet it? \n\nIf you don't get it, forget about it.";

            if (input.Contains("safe browsing") || input.Contains("internet") 
                || input.Contains("online safety") || input.Contains("web browsing")
                || input.Contains("Web") || input.Contains("Web Browsing")
                || input.Contains("Online Safety"))
                return "Safe Web Browsing\r\n-----------------\r\n\r\nCybercriminals use fake websites, malicious ads, and pop-ups to steal information. Stay safe online with these tips:\r\n\r\nHow to Browse the Web Safely:\r\n\r\n-> Always check for \"https://\" in the website URL—it means the site is encrypted.\r\n\r\n-> Avoid clicking on pop-ups, fake download buttons, or sketchy ads.\r\n\r\n-> Be cautious when entering personal info online—verify the site is legitimate.\r\n\r\n-> Use a secure browser with built-in protection (e.g., Google Chrome, Firefox, or Brave).\r\n\r\n-> Install a reliable ad-blocker to reduce exposure to malicious ads.\r\n\r\n-> Warning Signs of an Unsafe Website:\r\n\r\n-> The URL has misspellings (e.g., paypa1.com instead of paypal.com).\r\n\r\n->The site asks for sensitive info you wouldn’t normally provide.\r\n\r\n-> There are tons of pop-ups or forced downloads.\n\nStay safe. Stay frosty.";


            if (input.Contains("what is your purpose") || input.Contains("What are you")
                || input.Contains("Who are you") || input.Contains("what do you do"))
                return "My name is CyBot, a Cybersecurity Awareness Assistant.\nI'm here to help you stay safe in the digital world. Cyber thrests like phishing, data breaches, and ransomware can out personal and company data at risk. Whether you're protecting your personal accounts or securing your organisation's network. \r\n\r\n I provide insights on cyber attacks and best suggested practices to stay safe. Ask me anything about cybersecurity!";


            /*Oif (input.Contains("what is your purpose") || input.Contains("What are you")
                || input.Contains("Who are you") || input.Contains("what do you do"))
                return "My name is CyBot, a Cybersecurity Awareness Assistant.\nI'm here to help you stay safe in the digital world. Cyber thrests like phishing, data breaches, and ransomware can out personal and company data at risk. Whether you're protecting your personal accounts or securing your organisation's network. \r\n\r\n I provide insights on cyber attacks and best suggested practices to stay safe. Ask me anything about cybersecurity!";
            */
            return "I didn't quite understand that. Can you rephrase?";

            Console.ReadKey();
        }
    
    
    }
}