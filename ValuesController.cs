using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/Values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        //ex19
        [HttpGet("reverse")]
        public string reverse(int num)
        {
            num--;
            string arr ="";
            while (num!=0)
            {
                arr+= num;
                arr += ",";
                num--;
            }
             return arr;
        }

        // ex20
        [HttpGet("starMaker")]
        public string Get(int num)
        { 
            string stars ="";
            while(num!=0)
            {
                stars += "*";
                num--;
            }
            return stars;
        }
        //ex 10 
        [HttpGet("numerized")]
        public string Get(string word)
        {
            string result="";
            int counter = word.Length-1;
            char temp = word[counter];
            while (counter!=-1)
            {
                counter--;
                if (temp > 64 && temp < 91) // A-Z
                   result = result + (temp-64)+",";
                if (temp > 96 && temp < 123) // a-z
                    result = result + (temp - 96)+",";
                if (counter == -1)
                    break;
                temp = word[counter];

            }
            return result;
        }

        // ex9
        [HttpGet("Move1")]
        public string Move1 (string moveit)
        {
            string move = "";
            char temp = 'a';
            for(int i=0; i< moveit.Length; i++)
            {
                temp = moveit[i];
                temp++;
                move += temp;
                
            }
            return move;
        }


        // ex4
        [HttpGet("Wordy")]
        public string Wordy (string Wordz)
        {
            string[] Words = Wordz.Split(' ');
            string result = "";
            int odd = 1;
            foreach(string word in Words)
            {
                if (odd%2==1)
                {
                    result += word;
                    result += " ";
                }
                odd++;

            }
            return result;

        }

    }

    }

