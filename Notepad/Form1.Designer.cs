namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.play = new System.Windows.Forms.ToolStripButton();
            this.pause = new System.Windows.Forms.ToolStripButton();
            this.resume = new System.Windows.Forms.ToolStripButton();
            this.stop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(713, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator3,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripTextBox1,
            this.toolStripSeparator4,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.play,
            this.pause,
            this.resume,
            this.stop,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(713, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "a",
            "about",
            "above",
            "across",
            "act",
            "active",
            "activity",
            "add",
            "afraid",
            "after",
            "again",
            "age",
            "ago",
            "agree",
            "air",
            "all",
            "alone",
            "along",
            "already",
            "always",
            "am",
            "amount",
            "an",
            "and",
            "angry",
            "another",
            "answer",
            "any",
            "anyone",
            "anything",
            "anytime",
            "appear",
            "apple",
            "are",
            "area",
            "arm",
            "army",
            "around",
            "arrive",
            "art",
            "as",
            "ask",
            "at",
            "attack",
            "aunt",
            "autumn",
            "away",
            "B",
            "baby",
            "back",
            "bad",
            "bag",
            "ball",
            "bank",
            "base",
            "basket",
            "bath",
            "be",
            "bean",
            "bear",
            "beautiful",
            "bed",
            "bedroom",
            "beer",
            "before",
            "begin",
            "behave",
            "behind",
            "B cont.",
            "bell",
            "below",
            "besides",
            "best",
            "better",
            "between",
            "big",
            "bird",
            "birth",
            "birthday",
            "bit",
            "bite",
            "black",
            "bleed",
            "block",
            "blood",
            "blow",
            "blue",
            "board",
            "boat",
            "body",
            "boil",
            "bone",
            "book",
            "border",
            "born",
            "borrow",
            "both",
            "bottle",
            "bottom",
            "bowl",
            "box",
            "boy",
            "branch",
            "brave",
            "bread",
            "break",
            "breakfast",
            "breathe",
            "bridge",
            "bright",
            "bring",
            "brother",
            "brown",
            "brush",
            "build",
            "burn",
            "bus",
            "business",
            "busy",
            "but",
            "buy",
            "by",
            "C",
            "cake",
            "call",
            "can",
            "candle",
            "cap",
            "car",
            "card",
            "care",
            "careful",
            "careless",
            "carry",
            "case",
            "cat",
            "catch",
            "C cont.",
            "central",
            "century",
            "certain",
            "chair",
            "chance",
            "change",
            "chase",
            "cheap",
            "cheese",
            "chicken",
            "child",
            "children",
            "chocolate",
            "choice",
            "choose",
            "circle",
            "city",
            "class",
            "clean",
            "clear",
            "clever",
            "climb",
            "clock",
            "close",
            "cloth",
            "clothes",
            "cloud",
            "cloudy",
            "coat",
            "coffee",
            "coin",
            "cold",
            "collect",
            "colour",
            "comb",
            "come",
            "comfortable",
            "common",
            "compare",
            "complete",
            "computer",
            "condition",
            "contain",
            "continue",
            "control",
            "cook",
            "cool",
            "copper",
            "corn",
            "corner",
            "correct",
            "cost",
            "count",
            "country",
            "course",
            "cover",
            "crash",
            "cross",
            "cry",
            "cup",
            "cupboard",
            "cut",
            "D",
            "dance",
            "dangerous",
            "dark",
            "daughter",
            "D",
            "day",
            "dead",
            "decide",
            "decrease",
            "deep",
            "deer",
            "depend",
            "desk",
            "destroy",
            "develop",
            "die",
            "different",
            "difficult",
            "dinner",
            "direction",
            "dirty",
            "discover",
            "dish",
            "do",
            "dog",
            "door",
            "double",
            "down",
            "draw",
            "dream",
            "dress",
            "drink",
            "drive",
            "drop",
            "dry",
            "duck",
            "dust",
            "duty",
            "E",
            "each",
            "ear",
            "early",
            "earn",
            "earth",
            "east",
            "easy",
            "eat",
            "education",
            "effect",
            "egg",
            "eight",
            "either",
            "electric",
            "elephant",
            "else",
            "empty",
            "end",
            "enemy",
            "enjoy",
            "enough",
            "enter",
            "entrance",
            "equal",
            "escape",
            "even",
            "evening",
            "event",
            "ever",
            "every",
            "everybody",
            "everyone",
            "exact",
            "examination",
            "E cont.",
            "example",
            "except",
            "excited",
            "exercise",
            "expect",
            "expensive",
            "explain",
            "extremely",
            "eye",
            "F",
            "face",
            "fact",
            "fail",
            "fall",
            "false",
            "family",
            "famous",
            "far",
            "farm",
            "fast",
            "fat",
            "father",
            "fault",
            "fear",
            "feed",
            "feel",
            "female",
            "fever",
            "few",
            "fight",
            "fill",
            "film",
            "find",
            "fine",
            "finger",
            "finish",
            "fire",
            "first",
            "fit",
            "five",
            "fix",
            "flag",
            "flat",
            "float",
            "floor",
            "flour",
            "flower",
            "fly",
            "fold",
            "food",
            "fool",
            "foot",
            "football",
            "for",
            "force",
            "foreign",
            "forest",
            "forget",
            "forgive",
            "fork",
            "form",
            "four",
            "fox",
            "free",
            "freedom",
            "freeze",
            "fresh",
            "friend",
            "F cont.",
            "friendly",
            "from",
            "front",
            "fruit",
            "full",
            "fun",
            "funny",
            "furniture",
            "further",
            "future",
            "G",
            "game",
            "garden",
            "gate",
            "general",
            "gentleman",
            "get",
            "gift",
            "give",
            "glad",
            "glass",
            "go",
            "goat",
            "god",
            "gold",
            "good",
            "goodbye",
            "grandfather",
            "grandmother",
            "grass",
            "grave",
            "great",
            "green",
            "grey",
            "ground",
            "group",
            "grow",
            "gun",
            "H",
            "hair",
            "half",
            "hall",
            "hammer",
            "hand",
            "happen",
            "happy",
            "hard",
            "hat",
            "hate",
            "have",
            "he",
            "head",
            "healthy",
            "hear",
            "heart",
            "heaven",
            "heavy",
            "height",
            "hello",
            "help",
            "hen",
            "her",
            "here",
            "hers",
            "hide",
            "high",
            "hill",
            "him",
            "H",
            "his",
            "hit",
            "hobby",
            "hold",
            "hole",
            "holiday",
            "home",
            "hope",
            "horse",
            "hospital",
            "hot",
            "hotel",
            "hour",
            "house",
            "how",
            "hundred",
            "hungry",
            "hurry",
            "hurt",
            "husband",
            "I",
            "I",
            "ice",
            "idea",
            "if",
            "important",
            "in",
            "increase",
            "inside",
            "into",
            "introduce",
            "invent",
            "invite",
            "iron",
            "is",
            "island",
            "it",
            "its",
            "J",
            "jelly",
            "job",
            "join",
            "juice",
            "jump",
            "just",
            "K",
            "keep",
            "key",
            "kill",
            "kind",
            "king",
            "kitchen",
            "knee",
            "knife",
            "knock",
            "know",
            "L",
            "ladder",
            "lady",
            "lamp",
            "land",
            "large",
            "last",
            "late",
            "lately",
            "laugh",
            "lazy",
            "lead",
            "leaf",
            "learn",
            "leave",
            "L cont.",
            "left",
            "leg",
            "lend",
            "length",
            "less",
            "lesson",
            "let",
            "letter",
            "library",
            "lie",
            "life",
            "light",
            "like",
            "lion",
            "lip",
            "list",
            "listen",
            "little",
            "live",
            "lock",
            "lonely",
            "long",
            "look",
            "lose",
            "lot",
            "love",
            "low",
            "lower",
            "luck",
            "M",
            "machine",
            "main",
            "make",
            "male",
            "man",
            "many",
            "map",
            "mark",
            "market",
            "marry",
            "matter",
            "may",
            "me",
            "meal",
            "mean",
            "measure",
            "meat",
            "medicine",
            "meet",
            "member",
            "mention",
            "method",
            "middle",
            "milk",
            "million",
            "mind",
            "minute",
            "miss",
            "mistake",
            "mix",
            "model",
            "modern",
            "moment",
            "money",
            "monkey",
            "month",
            "moon",
            "more",
            "M cont.",
            "morning",
            "most",
            "mother",
            "mountain",
            "mouth",
            "move",
            "much",
            "music",
            "must",
            "my",
            "N",
            "name",
            "narrow",
            "nation",
            "nature",
            "near",
            "nearly",
            "neck",
            "need",
            "needle",
            "neighbour",
            "neither",
            "net",
            "never",
            "new",
            "news",
            "newspaper",
            "next",
            "nice",
            "night",
            "nine",
            "no",
            "noble",
            "noise",
            "none",
            "nor",
            "north",
            "nose",
            "not",
            "nothing",
            "notice",
            "now",
            "number",
            "O",
            "obey",
            "object",
            "ocean",
            "of",
            "off",
            "offer",
            "office",
            "often",
            "oil",
            "old",
            "on",
            "one",
            "only",
            "open",
            "opposite",
            "or",
            "orange",
            "order",
            "other",
            "our",
            "out",
            "outside",
            "over",
            "own",
            "P",
            "page",
            "pain",
            "paint",
            "pair",
            "pan",
            "paper",
            "parent",
            "park",
            "part",
            "partner",
            "party",
            "pass",
            "past",
            "path",
            "pay",
            "peace",
            "pen",
            "pencil",
            "people",
            "pepper",
            "per",
            "perfect",
            "period",
            "person",
            "petrol",
            "photograph",
            "piano",
            "pick",
            "picture",
            "piece",
            "pig",
            "pin",
            "pink",
            "place",
            "plane",
            "plant",
            "plastic",
            "plate",
            "play",
            "please",
            "pleased",
            "plenty",
            "pocket",
            "point",
            "poison",
            "police",
            "polite",
            "pool",
            "poor",
            "popular",
            "position",
            "possible",
            "potato",
            "pour",
            "power",
            "present",
            "press",
            "pretty",
            "prevent",
            "price",
            "prince",
            "prison",
            "private",
            "prize",
            "probably",
            "problem",
            "produce",
            "P cont.",
            "promise",
            "proper",
            "protect",
            "provide",
            "public",
            "pull",
            "punish",
            "pupil",
            "push",
            "put",
            "Q",
            "queen",
            "question",
            "quick",
            "quiet",
            "quite",
            "R",
            "radio",
            "rain",
            "rainy",
            "raise",
            "reach",
            "read",
            "ready",
            "real",
            "really",
            "receive",
            "record",
            "red",
            "remember",
            "remind",
            "remove",
            "rent",
            "repair",
            "repeat",
            "reply",
            "report",
            "rest",
            "restaurant",
            "result",
            "return",
            "rice",
            "rich",
            "ride",
            "right",
            "ring",
            "rise",
            "road",
            "rob",
            "rock",
            "room",
            "round",
            "rubber",
            "rude",
            "rule",
            "ruler",
            "run",
            "rush",
            "S",
            "sad",
            "safe",
            "sail",
            "salt",
            "same",
            "sand",
            "save",
            "say",
            "school",
            "science",
            "scissors",
            "S cont.",
            "search",
            "seat",
            "second",
            "see",
            "seem",
            "sell",
            "send",
            "sentence",
            "serve",
            "seven",
            "several",
            "sex",
            "shade",
            "shadow",
            "shake",
            "shape",
            "share",
            "sharp",
            "she",
            "sheep",
            "sheet",
            "shelf",
            "shine",
            "ship",
            "shirt",
            "shoe",
            "shoot",
            "shop",
            "short",
            "should",
            "shoulder",
            "shout",
            "show",
            "sick",
            "side",
            "signal",
            "silence",
            "silly",
            "silver",
            "similar",
            "simple",
            "since",
            "sing",
            "single",
            "sink",
            "sister",
            "sit",
            "six",
            "size",
            "skill",
            "skin",
            "skirt",
            "sky",
            "sleep",
            "slip",
            "slow",
            "small",
            "smell",
            "smile",
            "smoke",
            "snow",
            "so",
            "soap",
            "sock",
            "soft",
            "some",
            "S",
            "someone",
            "something",
            "sometimes",
            "son",
            "soon",
            "sorry",
            "sound",
            "soup",
            "south",
            "space",
            "speak",
            "special",
            "speed",
            "spell",
            "spend",
            "spoon",
            "sport",
            "spread",
            "spring",
            "square",
            "stamp",
            "stand",
            "star",
            "start",
            "station",
            "stay",
            "steal",
            "steam",
            "step",
            "still",
            "stomach",
            "stone",
            "stop",
            "store",
            "storm",
            "story",
            "strange",
            "street",
            "strong",
            "structure",
            "student",
            "study",
            "stupid",
            "subject",
            "substance",
            "successful",
            "such",
            "sudden",
            "sugar",
            "suitable",
            "summer",
            "sun",
            "sunny",
            "support",
            "sure",
            "surprise",
            "sweet",
            "swim",
            "sword",
            "T",
            "table",
            "take",
            "talk",
            "tall",
            "taste",
            "taxi",
            "tea",
            "T cont.",
            "teach",
            "team",
            "tear",
            "telephone",
            "television",
            "tell",
            "ten",
            "tennis",
            "terrible",
            "test",
            "than",
            "that",
            "the",
            "their",
            "then",
            "there",
            "therefore",
            "these",
            "thick",
            "thin",
            "thing",
            "think",
            "third",
            "this",
            "though",
            "threat",
            "three",
            "tidy",
            "tie",
            "title",
            "to",
            "today",
            "toe",
            "together",
            "tomorrow",
            "tonight",
            "too",
            "tool",
            "tooth",
            "top",
            "total",
            "touch",
            "town",
            "train",
            "tram",
            "travel",
            "tree",
            "trouble",
            "true",
            "trust",
            "try",
            "turn",
            "twice",
            "type",
            "U",
            "uncle",
            "under",
            "understand",
            "unit",
            "until",
            "up",
            "use",
            "useful",
            "usual",
            "usually",
            "V",
            "vegetable",
            "very",
            "V cont.",
            "village",
            "visit",
            "voice",
            "W",
            "wait",
            "wake",
            "walk",
            "want",
            "warm",
            "wash",
            "waste",
            "watch",
            "water",
            "way",
            "we",
            "weak",
            "wear",
            "weather",
            "wedding",
            "week",
            "weight",
            "welcome",
            "well",
            "west",
            "wet",
            "what",
            "wheel",
            "when",
            "where",
            "which",
            "while",
            "white",
            "who",
            "why",
            "wide",
            "wife",
            "wild",
            "will",
            "win",
            "wind",
            "window",
            "wine",
            "winter",
            "wire",
            "wise",
            "wish",
            "with",
            "without",
            "woman",
            "wonder",
            "word",
            "work",
            "world",
            "worry",
            "worst",
            "write",
            "wrong",
            "Y",
            "year",
            "yes",
            "yesterday",
            "yet",
            "you",
            "young",
            "your",
            "Z",
            "zero",
            "zoo"});
            this.toolStripTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.toolStripTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextBox1.ToolTipText = "Enter Text to search";
            this.toolStripTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toolStripTextBox1_KeyPress);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 358);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged_1);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Search";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Change font";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Close tab";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // play
            // 
            this.play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(23, 22);
            this.play.Text = "Play Text";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(23, 22);
            this.pause.Text = "Pause";
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // resume
            // 
            this.resume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resume.Image = ((System.Drawing.Image)(resources.GetObject("resume.Image")));
            this.resume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(23, 22);
            this.resume.Text = "Resume";
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // stop
            // 
            this.stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(23, 22);
            this.stop.Text = "Stop";
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = global::Notepad.Properties.Resources.New;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::Notepad.Properties.Resources.Open;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Notepad.Properties.Resources.Save;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save ";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Notepad.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Image = global::Notepad.Properties.Resources.Undo;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Image = global::Notepad.Properties.Resources.Redo;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = global::Notepad.Properties.Resources.Cut;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "&Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = global::Notepad.Properties.Resources.Copy;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "Cop&y";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = global::Notepad.Properties.Resources.Paste;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::Notepad.Properties.Resources.Select;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "&Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 407);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Notepad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton play;
        private System.Windows.Forms.ToolStripButton pause;
        private System.Windows.Forms.ToolStripButton resume;
        private System.Windows.Forms.ToolStripButton stop;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}

