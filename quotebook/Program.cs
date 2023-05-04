// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Source source = new Source("None Were with Him", "http://www.churchofjesuschrist.org");

//Console.WriteLine(source.Stringify());

//Quote holland = new Quote("Elder Holland","Becauase Jesus walked such a long, lonely paht utterly alone, we do not have to do so",source);

//Console.WriteLine(holland.GetQuote());

//Board quoteboard = new Board();
//quoteboard.AddQuote(holland);
//quoteboard.FindQuotesByAuthor("holland");

Board _board = new Board();
_board.AddQuote(new Quote("Alma", "Live in thanksgiving daily",new Source("Alma 34:38")));
_board.AddQuote(new Quote("Elder Holland","Becauase Jesus walked such a long, lonely paht utterly alone, we do not have to do so",
new Source("None Were with Him", "http://www.churchofjesuschrist.org")));
_board.AddQuote(new Quote("Alma","If ye have faith ye hope for things which are not seen, which are true", new Source("Alma 32:21")));
_board.AddQuote(new Quote("Nephi", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
new Source("1 Nephi 3:7")));



//_board.GetRandomQuote();

Menu _menu = new Menu(_board);

_menu.Display();