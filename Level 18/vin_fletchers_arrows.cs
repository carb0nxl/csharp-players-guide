
        Console.WriteLine("Let's build an arrow!\n");
    
        Arrow arrow1 = new Arrow();
        Arrow.Summary();

    public class Arrow
    {
        // FIELDS
        private int _shaftLength;
        private Arrowhead _arrowheadSelection;
        private Fletching _fletchingSelection;
        private double _totalCost;
        
        private const int MIN_SHAFT_LENGTH = 60; // 60 cm
        private const int MAX_SHAFT_LENGTH = 100; // 100 cm
        
        // ARROW MATERIAL PRICING (in gold)
        private const double STEEL_PRICE = 10.00;
        private const double OBSIDIAN_PRICE = 5.00;
        private const double WOOD_PRICE = 3.00;

        private const double PLASTIC_FLETCH_PRICE = 10.00;
        private const double TURKEYFEATHER_FLETCH_PRICE = 5.00;
        private const double GOOSEFEATHER_FLETCH_PRICE = 3.00;

        private const double SHAFT_PRICE_PER_CM = 0.05; // 0.05 gold per cm for shaft
        

        // CONSTRUCTOR
        public Arrow(int shaftLength, Arrowhead arrowheadSelection, Fletching fletchingSelection, double totalCost)
        {
            ShaftLength = shaftLength;
            ArrowheadSelection = arrowheadSelection;
            FletchingSelection = fletchingSelection;
            TotalCost = totalCost;
        }
        
        // PROPERTIES
        public Arrowhead ArrowheadSelection
        {
            get { return _arrowheadSelection; }
            set { _arrowheadSelection = value; }
        }
        public Fletching FletchingSelection
        {
            get { return _fletchingSelection; }
            set { _fletchingSelection = value; }
        }
        public int ShaftLength
        {
            get { return _shaftLength; }
            set
            {
                if (value >= MIN_SHAFT_LENGTH && value <= MAX_SHAFT_LENGTH)
                {
                    _shaftLength = value;
                }
                else
                {
                    throw new ArgumentException("Shaft length must be between 60 and 100 cm.");
                }
            }
        }
        public double TotalCost
        {
            get { return _totalCost; }
            set { _totalCost = value; }
        }

        public void Summary()
        {
            // Provide a summary of the user's arrow:
            Console.WriteLine("\nYour Custom Arrow:");
            Console.WriteLine($"Arrowhead: {_Arrowhead}");
            Console.WriteLine($"Fletching: {_Fletching}");
            Console.WriteLine($"Shaft Length: {_ShaftLength} cm");
            Console.WriteLine($"Total cost for each arrow: {_TotalCost.ToString("F2")} gold.");
            Console.WriteLine("\nThanks for using VIN FLETCHER'S ARROW SHOP!");
            Console.ReadLine();  // Wait for the user to press Enter before closing.
        }

        // METHOD: Arrow selection menu
        Arrowhead SelectArrowheadMenu()
        {
            Console.WriteLine("Welcome to VIN FLETCHER'S ARROW SHOP");
            Console.WriteLine("====================================");
            Console.WriteLine("ARROWHEADS: Steel | Wood | Obsidian");
            Console.WriteLine($"A. Steel ----- {STEEL_PRICE} gold");
            Console.WriteLine($"B. Obsidian -- {OBSIDIAN_PRICE} gold");
            Console.WriteLine($"C. Wood ------ {WOOD_PRICE} gold");

            Console.Write("\nPlease input your choice of arrowhead using the LETTER only: ");

            // Run the ParseArrowheadInput method here to get input & assign it to (enum) arrowhead variable
            Arrowhead playerSelection = ParseArrowheadInput();
            return playerSelection;
        }
        
        // METHOD: Parsing user input for arrowhead selection
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
        
        // METHOD: Fletching selection menu
        Fletching SelectFletchingMenu()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("FLETCHING: Plastic | Turkey Feathers | Goose Feathers");
            Console.WriteLine($"A. Plastic -------------- {PLASTIC_FLETCH_PRICE} gold");
            Console.WriteLine($"B. Turkey Feathers ------ {TURKEYFEATHER_FLETCH_PRICE} gold");
            Console.WriteLine($"C. Goose Feathers ------- {GOOSEFEATHER_FLETCH_PRICE} gold");

            Console.Write("\nPlease input your choice of fletching using the LETTER only: ");
            
            Fletching playerSelection = ParseFletchingInput();
            return playerSelection;
        }
        
        //METHOD: Parsing user input for fletching
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
                    arrowheadCost = STEELPRICE;
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
                    fletchingCost = PlasticFletchPrice;
                    break;
                case Fletching.TurkeyFeather:
                    fletchingCost = TurkeyFeatherPrice;
                    break;
                case Fletching.GooseFeather:
                    fletchingCost = GooseFeatherPrice;
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