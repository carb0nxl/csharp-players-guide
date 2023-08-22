namespace DefaultNamespace;

        Console.WriteLine("Let's build an arrow!\n");
    
        Arrow arrow1 = new Arrow();


    public class Arrow
    {
        // properties
        public int _ShaftLength;
        public Arrowhead _Arrowhead;
        public Fletching _Fletching;
        public double _TotalCost;
        
        // arrow material pricing
        private const double STEEL_PRICE = 10.0;
        private const double OBSIDIAN_PRICE = 5.0;
        private const double WOOD_PRICE = 3.0;

        private const double PLASTIC_FLETCH_PRICE = 10.0;
        private const double TURKEY_FEATHER_PRICE = 5.0;
        private const double GOOSE_FEATHER_PRICE = 3.0;

        private const double SHAFT_PRICE_PER_CM = 0.05;

        // constructor
        public Arrow()
        {
            _Arrowhead = SelectArrowhead();
            _Fletching = SelectFletching();
            _ShaftLength = GetShaftLength();
            _TotalCost = CalculateCost();
            
            // Provide a summary of the user's arrow:
            Console.WriteLine("\nYour Custom Arrow:");
            Console.WriteLine($"Arrowhead: {_Arrowhead}");
            Console.WriteLine($"Fletching: {_Fletching}");
            Console.WriteLine($"Shaft Length: {_ShaftLength} cm");
            Console.WriteLine($"Total cost for each arrow: {_TotalCost.ToString("F2")} gold.");
            Console.WriteLine("\nThanks for using VIN FLETCHER'S ARROW SHOP!");
            Console.ReadLine();  // Wait for the user to press Enter before closing.
        }

        
        Arrowhead SelectArrowhead()
        {
            Console.WriteLine("Welcome to VIN FLETCHER'S ARROW SHOP");
            Console.WriteLine("====================================");
            Console.WriteLine("ARROWHEADS: Steel | Wood | Obsidian");
            Console.WriteLine("A. Steel ----- 10 gold");
            Console.WriteLine("B. Obsidian -- 5 gold");
            Console.WriteLine("C. Wood ------ 3 gold");

            Console.Write("\nPlease input your choice of arrowhead using the LETTER only: ");

            // Run the ParseArrowheadInput method here to get input & assign it to (enum) arrowhead variable
            Arrowhead playerSelection = ParseArrowheadInput();

            return playerSelection;
        }
        Arrowhead ParseArrowheadInput()
        {
            while (true)
            {
                string playerInput = Console.ReadLine();

                if (playerInput == "A" || playerInput == "a")
                {
                    Console.WriteLine("You've selected steel arrowheads.");
                    return Arrowhead.Steel;
                }
                else if (playerInput == "B" || playerInput == "b")
                {
                    Console.WriteLine("You've selected obsidian arrowheads.");
                    return Arrowhead.Obsidian;
                }
                else if (playerInput == "C" || playerInput == "c")
                {
                    Console.WriteLine("You've selected wood arrowheads.");
                    return Arrowhead.Wood;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again using letters.");
                }
            }
        }
        
        Fletching SelectFletching()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("FLETCHING: Plastic | Turkey Feathers | Goose Feathers");
            Console.WriteLine("A. Plastic -------------- 10 gold");
            Console.WriteLine("B. Turkey Feathers ------ 5 gold");
            Console.WriteLine("C. Goose Feathers ------- 3 gold");

            Console.Write("\nPlease input your choice of fletching using the LETTER only: ");
            
            Fletching playerSelection = ParseFletchingInput();
            return playerSelection;
        }
        Fletching ParseFletchingInput()
        {
            while (true)
            {
                string playerInput = Console.ReadLine();

                if (playerInput == "A" || playerInput == "a")
                {
                    Console.WriteLine("You've selected the plastic fletching.");
                    return Fletching.Plastic;
                }
                else if (playerInput == "B" || playerInput == "b")
                {
                    Console.WriteLine("You've selected the turkey feather fletching.");
                    return Fletching.TurkeyFeather;
                }
                else if (playerInput == "C" || playerInput == "c")
                {
                    Console.WriteLine("You've selected the goose feather fletching.");
                    return Fletching.GooseFeather;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again using letters.");
                }
            }
        }
        
        
        int GetShaftLength()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("SHAFT LENGTH");
            Console.WriteLine("Simply choose a length between");
            Console.WriteLine("60 to 100 centimeters (cm).");
            Console.WriteLine("((Please use whole numbers only))");

            return ShaftLengthParse();
        }

        int ShaftLengthParse()
        {
            while (true)
            {
                Console.Write("Enter desired shaft length: ");
                int shaftLengthNumber = int.Parse(Console.ReadLine());

                if (shaftLengthNumber >= 60 && shaftLengthNumber <= 100)
                {
                    return shaftLengthNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input!\n");
                }
            }
        }

        double CalculateCost()
        {
            double arrowheadCost = 0;
            double fletchingCost = 0;

            switch (_Arrowhead)
            {
                case Arrowhead.Steel:
                    arrowheadCost = STEEL_PRICE;
                    break;
                case Arrowhead.Obsidian:
                    arrowheadCost = OBSIDIAN_PRICE;
                    break;
                case Arrowhead.Wood:
                    arrowheadCost = WOOD_PRICE;
                    break;
                default:
                    arrowheadCost = 0;
                    break;
            }
            switch (_Fletching)
            {
                case Fletching.Plastic:
                    fletchingCost = PLASTIC_FLETCH_PRICE;
                    break;
                case Fletching.TurkeyFeather:
                    fletchingCost = TURKEY_FEATHER_PRICE;
                    break;
                case Fletching.GooseFeather:
                    fletchingCost = GOOSE_FEATHER_PRICE;
                    break;
                default:
                    fletchingCost = 0;
                    break;
            }
            
            
            double shaftCost = SHAFT_PRICE_PER_CM * _ShaftLength;

            return arrowheadCost + fletchingCost + shaftCost;
        }
        
    }
    
        


    public enum Arrowhead { Steel, Wood, Obsidian }

    public enum Fletching { Plastic, TurkeyFeather, GooseFeather }