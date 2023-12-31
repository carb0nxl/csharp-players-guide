
        Console.WriteLine("Let's build an arrow!\n");
    
        Arrow arrow1 = new Arrow();


    public class Arrow()
    {
        // Private fields for the arrow's components
        private int _shaftLength;
        private Arrowhead _arrowheadSelection;
        private Fletching _fletchingSelection;
        
        private const int MIN_SHAFT_LENGTH = 60;    // Minimum shaft length in cm
        private const int MAX_SHAFT_LENGTH = 100;   // Maximum shaft length in cm
        
        // Constants for arrow's specifications and pricing
        private const double STEEL_PRICE = 10.00;
        private const double OBSIDIAN_PRICE = 5.00;
        private const double WOOD_PRICE = 3.00;

        private const double PLASTIC_FLETCH_PRICE = 10.00;
        private const double TURKEYFEATHER_FLETCH_PRICE = 5.00;
        private const double GOOSEFEATHER_FLETCH_PRICE = 3.00;

        private const double SHAFT_PRICE_PER_CM = 0.05; // 0.05 gold per centimeter (cm)
        
        // Properties for the arrow's components
        public Arrowhead ArrowheadSelection { get { return _arrowheadSelection; } set { _arrowheadSelection = value; } }
        public Fletching FletchingSelection { get { return _fletchingSelection; } set { _fletchingSelection = value; } }


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
            get { return CalculateCost(); }
        }

        // Constructor initializes the arrow by prompting the user's selections
        public Arrow()
        {
            ArrowheadSelection = SelectArrowheadMenu();
            FletchingSelection = SelectFletchingMenu();
            ShaftLength = GetShaftLength();
            Summary();
        }

        
        // Method to display a summary of the user's custom arrow
        public void Summary()
        {
            Console.WriteLine("\nYour Custom Arrow:");
            Console.WriteLine($"Arrowhead: {ArrowheadSelection}");
            Console.WriteLine($"Fletching: {FletchingSelection}");
            Console.WriteLine($"Shaft Length: {ShaftLength} cm");
            Console.WriteLine($"Total cost for each arrow: {TotalCost.ToString("F2")} gold.");
            Console.WriteLine("\nThanks for using VIN FLETCHER'S ARROW SHOP!");
            Console.WriteLine("\nPress any key to exit the program.");
            Console.ReadLine();  // Wait for the user to press Enter before closing.
        }

        // Methods related to user's selection for each arrow component
        private Arrowhead SelectArrowheadMenu()
        {
            Console.WriteLine("Welcome to VIN FLETCHER'S ARROW SHOP");
            Console.WriteLine("====================================");
            Console.WriteLine("ARROWHEADS: Steel | Wood | Obsidian");
            Console.WriteLine($"A. Steel ------- {STEEL_PRICE} gold");
            Console.WriteLine($"B. Obsidian ---- {OBSIDIAN_PRICE} gold");
            Console.WriteLine($"C. Wood -------- {WOOD_PRICE} gold");

            Console.Write("\nPlease input your choice of arrowhead using the LETTER only: ");

            // Run the ParseArrowheadInput method here to get input & assign it to (enum) arrowhead variable
            Arrowhead playerSelection = ParseArrowheadInput();
            return playerSelection;
        }
        
        // Method to parse the user's input for shaft length, ensuring it's within bounds
        private Arrowhead ParseArrowheadInput()
        {
            // Loop until a valid shaft length is provided
            while (true)
            {
                string playerInput = Console.ReadLine();

                if (string.Equals(playerInput, "A", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You've selected steel arrowheads.");
                    return Arrowhead.Steel;
                }
                else if (string.Equals(playerInput, "B", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You've selected obsidian arrowheads.");
                    return Arrowhead.Obsidian;
                }
                else if (string.Equals(playerInput, "C", StringComparison.OrdinalIgnoreCase))
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
        
        // ~~~~ METHOD: Fletching selection menu ~~~~ 
        private Fletching SelectFletchingMenu()
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
        
        // ~~~~ METHOD: Parsing user input for fletching ~~~~ 
        private Fletching ParseFletchingInput()
        {
            while (true)
            {
                string playerInput = Console.ReadLine();

                if (string.Equals(playerInput, "A", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You've selected the plastic fletching.");
                    return Fletching.Plastic;
                }
                else if (string.Equals(playerInput, "B", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("You've selected the turkey feather fletching.");
                    return Fletching.TurkeyFeather;
                }
                else if (string.Equals(playerInput, "C", StringComparison.OrdinalIgnoreCase))
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
        
        private int GetShaftLength()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("SHAFT LENGTH");
            Console.WriteLine("Simply choose a length between");
            Console.WriteLine("60 to 100 centimeters (cm).");
            Console.WriteLine("((Please use whole numbers only))");

            return ShaftLengthParse();
        }
// ~~~~ METHOD: Parsing user input for shaft length within parameters ~~~~ 
        private int ShaftLengthParse()
        {
            while (true)
            {
                Console.Write("Enter desired shaft length: ");
                if (int.TryParse(Console.ReadLine(), out int shaftLengthNumber) &&
                    shaftLengthNumber >= MIN_SHAFT_LENGTH && shaftLengthNumber <= MAX_SHAFT_LENGTH)
                {
                    return shaftLengthNumber;
                }
                else
                {
                    Console.WriteLine("Invalid input! Please enter a whole number between 60 and 100.\n");
                }
            }
        }


        // Method to calculate the total cost of the arrow based on selected components
        private double CalculateCost()
        {
            double arrowheadCost = 0;
            double fletchingCost = 0;
                
            // Assign cost based on arrowhead selection
            switch (_arrowheadSelection)
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
            // ~~~~ Assign cost based on fletching selection ~~~~ 
            switch (_fletchingSelection)
            {
                case Fletching.Plastic:
                    fletchingCost = PLASTIC_FLETCH_PRICE;
                    break;
                case Fletching.TurkeyFeather:
                    fletchingCost = TURKEYFEATHER_FLETCH_PRICE;
                    break;
                case Fletching.GooseFeather:
                    fletchingCost = GOOSEFEATHER_FLETCH_PRICE;
                    break;
                default:
                    fletchingCost = 0;
                    break;
            }
            // declare shaftCost and calculate it here
            double shaftCost = SHAFT_PRICE_PER_CM * _shaftLength;
            
            
            // return the cumulative cost as a DOUBLE
            return arrowheadCost + fletchingCost + shaftCost;
        }
    }
    // Enumerators for the different types of arrow components
    public enum Arrowhead { Steel, Wood, Obsidian }

    public enum Fletching { Plastic, TurkeyFeather, GooseFeather }