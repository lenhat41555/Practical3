using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Practical3
{
    class Program
    {
         public static void Main()
        {
            Program t = new Program();
            Cat c = new Cat();
            int choice;
            Console.WriteLine("1.Create  a Crocodile");
            Console.WriteLine("2.Create  a Cat");
            Console.WriteLine("3.Create  a Fish");
            Console.WriteLine("4.view Terrestrial Animals");
            Console.WriteLine("5.view Marine Animals");
            Console.WriteLine("6.view All Animals");
            Console.WriteLine("7.Delete Animal ");
            Console.WriteLine("8.Exit");
            do
            {
                Console.Write("\nPlease select an item:");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    
                    case 1: t.AddCrocodile();
                    break;
                    case 2: t.AddCat();
                    break;
                     case 3: t.AddFish();
                    break;
                    case 4: t.ViewTerrestrialAnimals();
                    break;
                     case 5: t.ViewMarineAnimals();
                    break;
                    case 6: t.ViewAllAnimals();
                    break;

                    case 7: t.deleteAnimals();
                    break;
                    case 8: return;
                }

            } while (choice !=8);
            }
              int count = 0;
        Hashtable ListAnimal = new Hashtable();
        public void AddCat()
        {
            Cat obj = new Cat();
            obj.ID = count;
            Console.Write("Name of cat:");
            obj.Name = Console.ReadLine();
            Console.Write("Age of cat:");
            obj.Age= int.Parse(Console.ReadLine());
            ListAnimal.Add(count, obj);
            count++;
        }
        public void AddCrocodile()
        {
            Crocodile obj = new Crocodile();
            obj.ID =count;
            Console.Write("Name of crocodile:");
            obj.Name= Console.ReadLine();
            Console.Write("Age of crocodile:");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count,obj);
            count++;
        }
public void AddFish()
        {
            Fish obj = new Fish();
            obj.ID =count;
            Console.Write("Name of Fish:");
            obj.Name= Console.ReadLine();
            Console.Write("Age of Fish:");
            obj.Age = int.Parse(Console.ReadLine());
            ListAnimal.Add(count,obj);
            count++;
        }
        public void ViewTerrestrialAnimals()
        {
            Cat c= new Cat();
            for (int i = 0; i<ListAnimal.Count; i++)
            if (ListAnimal[i].GetType().Equals(c.GetType()))
            {
                ListAnimal[i].ToString();
                c.Move();
            }
        }
        public void ViewMarineAnimals()
        {
            Fish f = new Fish();
            for (int i=0; i <ListAnimal.Count; i++)
            if (ListAnimal[i].GetType().Equals(f.GetType()))
            {
                ListAnimal [i].ToString();
                f.Move();
            }
        }
        public void ViewAllAnimals()
        {
            foreach (DictionaryEntry de  in ListAnimal.Values)
            Console.WriteLine(de);
        }
        public void deleteAnimals()
        {
            int n;
            Console.Write("Please select akey:");
            int.TryParse(Console.ReadLine(),out n);
            foreach (DictionaryEntry de in ListAnimal)
            if (de.Key.Equals(n))
            {
                ListAnimal.Remove(n);
                break;
            }
            Console.WriteLine(ListAnimal.Count);
        }   
        

        }
    }
