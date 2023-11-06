using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CulinarReceips
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Choose_receip(object sender, RoutedEventArgs e)
        {
            ListBoxItem receip = (ListBoxItem)((ListBox)sender).SelectedItem;
            switch (receip.Content)
            {
                case "Панкейки":
                    Pancakes();
                    break;
                case "Свиные ребра":
                    PigBones(); 
                    break;
                case "Банановый кекс":
                    BananaCake();
                    break;
                case "Брауни":
                    Brauni();
                    break;
                case "Гамбургер":
                    Hamburger();
                    break;
                case "Вальдорфский салат":
                    ValdorfskijSalat();
                    break;
                case "Гранола":
                    Granola();
                    break;
                case "Капкейки":
                    Cupcake();
                    break;
                case "Луковые кольца":
                    OnionCircles();
                    break;
                case "Бифштекс":
                    Beefstake();
                    break;

            }

        }
        private void OnionCircles()
        {
            Run run1 = new Run("Луковые кольца");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.GhostWhite;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../tsibulevi-kiltsya.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "Безусловно, все мы видели луковые кольца в различных меню баров и пабов, и скорее всего у некоторых возникал вопрос, а как же их приготовить? Сегодня, я поделюсь с вами рецептом луковых колечек.\r\n\r\nНо сперва, хотелось бы сказать, что эти луковые кольца – очень популярны в Европе, не только как к пиву, а и как дополнения к рыбным, мясным и даже овощным блюдам. Данная закуска, появилась около века назад в южном районе Америке.Луковые колечки имеют своеобразный вкус. Если, вы думаете – что кольца будут отдавать ярко-выраженным вкусом лука, то вы ошибаетесь. После жарки, лук становится полумягким и сладким, а кляр дополняет его своей хрусткостью. Обжаренный кляр с луком внутри - невероятно вкусное сочетание и получается идеальная закуска.\r\n\r\n    Также, если вы хотите дополнить свои луковые кольца другими вкусами, тогда вы можете добавить в кляр абсолютно любые специи. Конечно же, можно приготовить к ним различные соусе. Например, подавать кольца луковые не только с простой сметаной, майонезом или кетчупом, а с грибным соусом, сырным или барбекю-соус. Ещё, можно в обще, не заморачиваться и купить в магазине уже готовый соус.\r\n    Однако, главным секретом этих нехитрых луковых колец является идеальная пышная и круглая форма, которую вы могли увидеть в кафе или на страницах кулинарных журналов. Конечно же, основная задача состоит в том, чтобы приготовить луковые кольца, такие же, в домашних условиях. Вы спросите, а в чём же секрет луковых колец? Ответ очень прост – секрет в приготовлении кляра. Хотя, если рассудить, то секрета никакого и нет. Потому, здесь важно выдержать все пропорции, дабы кляр получился удачным и не полностью стекал от кольца, когда вы будете его погружать и доставать. Как, я уже написала выше, готовятся они очень просто и быстро, а это значит, что луковые кольца чудесно подойдут для приготовления на скорую руку, когда гости вот-вот и окажутся за вашим порогом. Без лишних слов, красивые луковые колечки украсят любой ваш праздничный стол, ведь согласитесь не так часто хозяйки готовят кольца.\r\n    Если, вы часто ездите на пикники, то луковые кольца идеально подойдут к шашлыку. И даже, если вы правильно приготовите их, за два-три часа до пикника – они не потеряют своего вкуса, и кляр останется хрустящим. \r\n    Рецепт луковых колец прост и доступен для приготовления, но также мы можем вспомнить и о других различным способов приготовления. Так как, данное блюдо можно готовить абсолютно с любыми начинками. Самыми популярными это с мясным фаршем, с вкусным сыром мацареллой, с ветчиной, салями, грибной и так далее. Но для начала давайте ознакомимся с традиционным процессом приготовления луковых колец, а уже после можно будет поэкспериментировать с начинками или же, приготовить кольца с популярными начинками.";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Луковые кольца");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run(" Растительное масло 250 мл")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Мука 5 - 6 ст.ложек")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Куриные яйца 2 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Соль по вкусу")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Специи по вкусу")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сметана 2 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Репчатый лук 1 - 2 шт.")));

            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void Cupcake()
        {
            Run run1 = new Run("Капкейк");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.LightSkyBlue;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../kapkejki.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\n    Традиционный капкейк выпекается из тех же ингредиентов, что и обычный бисквит: пшеничная мука, масло, молоко, яйца, сахар. Практически любой рецепт теста для пирога подойдет и для капкейков. В тесто могут быть добавлены различные ингредиенты: кокосовая или шоколадная стружка, орехи, ягоды, изюм. Из-за небольшого размера капкейки выпекаются гораздо быстрее обычного кекса. Для их приготовления требуется 15-17 минут при температуре 180 градусов Цельсия.\r\n    Капкейки могут заполняться глазурью или кондитерским кремом. Для этого в верхней части испеченного изделия делают небольшое отверстие с помощью ножа или ложки. В отверстие выпускают крем.\r\n    Верхняя часть капкейка не обязательно должна иметь большую кремовую «шапку». Иногда их просто поливают шоколадной глазурью или смазывают тонким слоем крема.\r\n    Первоначально капкейки выпекались в керамических чашках. Дословно cupcake переводится как «чашечный торт». Некоторые пекари до сих пор используют небольшие кружки, чашки или другие гончарные изделия. Однако сейчас чаще всего используются специальные противни для маффинов. Как правило, они изготавливаются из металла с антипригарным покрытием. Также используется силикон, керамика и другие материалы.\r\n    Капкейки обычно подаются в специальных бумажных формах, которые имеют эстетическое и санитарное значение. Бумага защищает изделие от микробов при передаче капкейка из рук в руки. Также она выполняет функцию индивидуального блюдечка и салфетки одновременно. Выпускаются вкладыши разных форм и размеров, в зависимости от размеров самих капкейков. Для изготовления вкладышей может также использоваться тонкая алюминиевая фольга или силикон (для многоразового использования).\r\n    Предварительно прогревайте все ингредиенты до комнатной температуры. Так они лучше соединяются и делают тесто более однородным. Подержите продукты на столе примерно полчаса перед приготовлением.\r\n    Если вы используете металлический противень с формами для маффинов, нужно заполнять их все. Если остаются пустые формы, влейте в них холодной воды примерно на 1/3 высоты. Так алюминий в духовке не будет коробиться.\r\n    Для длительного хранения выставляйте капкейки в достаточно высокую посуду, герметично закрывайте и замораживайте. Так они будут дольше оставаться свежими. Но вкус от этого портится, так что лучше съесть их за 1-2 дня. Учитывая наличие масляного крема, дольше хранить изделия не рекомендуется. Летом их нужно съедать за сутки, ведь масло быстро портится в тепле.\r\n    Капкейки – отличный вариант десерта на различные праздники. Особенно популярны они на детских днях рождения, свадьбах, фуршетах. Главное удобство этой выпечки в том, что ее не нужно нарезать. Украшать капкейки можно стандартно (посыпка, цветочки из мастики и т.д), а можно оформить их в тематическом стиле. К примеру, если именинник – любитель определенного мультика, капкейки украшаются изображениями героя этого мультфильма. На вечеринку футболистов можно приготовить капкейки с глазурью в виде футбольного мяча. Проявите фантазию, и обычная выпечка превратится в центральную часть застолья.\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Капкейк");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Пшеничная мука 100 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Куриные яйца 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Соль 0,5 ч.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сахар 3 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сода 0,5 ч.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Ванильный сахар 1 ч.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Шоколад молочный 30 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Для крема")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Уксус 0,5 ч.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Посыпка кондитерская 5 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сливочное масло 100 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сахар 1,5 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сметана 30 г.")));
            myList.ListItems.Add(listItem);

      
            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void Granola()
        {
            Run run1 = new Run("Гранола");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.LightGray;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../granola-.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\n    Гранолой называется и рассыпчатая смесь для завтрака, и батончики. По составу практически никакой разницы между ними нет. Единственное различие заключается в том, что снек спрессован в прямоугольную форму. На фабриках батончики прессуют под высоким давлением. В домашних условиях для этого добавляют жидкий мед, который скрепляет между собой все ингредиенты.\r\n    Такие батончики рекомендуется брать с собой для перекуса туристам, отправляющимся в лес, горы. Маленький снек быстро насыщает организм калориями, витаминами, углеводами. К тому же такая домашняя сладость несравненно полезнее покупных батончиков с разными консервантами, вкусовыми добавками.\r\n    Чтобы сделать батончик, вам понадобится любая прямоугольная форма. Подойдет форма для кекса, хлеба, запекания. Дно и бортики выстилают пленкой, фольгой, пергаментной бумагой, чтобы заготовку было удобно вынимать.\r\n    Батончики могут также улучшить пищеварение, если добавлять в них семена льна. Иногда также добавляют рис. Как и овсянку, его нужно предварительно обжарить (или запечь) до хруста.\r\n    Поскольку снек впитывает влагу из воздуха, хранить его можно только в герметично закрытой упаковке и обязательно в холодильнике.\r\n    Растительное масло используется обязательно. Конечно, это повышает калорийность, но с маслом ингредиенты лучше скрепляются между собой.\r\n    В домашнюю гранолу вы можете добавлять курагу, чернослив, другие сухофрукты, арахис, фисташки, кокосовую стружку, семечки тыквы или подсолнечника. Словом, простор для фантазии открыт. Главное, чтобы все было нарезано мелкими кусочками. Только помните, что гранола – это полезная пища. Не нужно добавлять в нее кусочки конфет, сахар и прочие не слишком полезные продукты.\r\n    Несмотря на исключительно натуральные ингредиенты, гранола все же достаточно сладкая. Это следует учитывать при диабете и других проблемах со здоровьем, которые ограничивают употребление сладкой пищи.\r\n    Вместо меда можно использовать густой сладкий сироп. В США и Канаде часто добавляют кленовый сироп. Конечно, у нас найти его сложно, поэтому проще приготовить сироп самому из сахара и воды. Но стоит заметить, что мед будет и вкуснее, и полезнее. Подслащивать гранолу дополнительно не нужно. В сухофруктах, меде, шоколаде содержится достаточно глюкозы и фруктозы.\r\n    Из специй можно добавлять корицу, гвоздику, мускатный орех, лимонную цедру, ваниль.\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Гранола");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Растительное масло 1 ч.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Соль Маленькая щепотка")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Изюм 50 г")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Овсяные хлопья 200 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Грецкий орех 50 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Шоколад черный 30 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Мед 40 г.")));
            myList.ListItems.Add(listItem);
                                 

            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void ValdorfskijSalat()
        {
            Run run1 = new Run("Вальдорфский салат");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.Lime;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../valdorfskij-salat.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\nЕсли хочется необычного, вкусного и полезного попробуйте этот салат. Возможно это не самый практичный вариант для праздничного стола, но именно то, для себя любимой я иногда организовываю такие «любимые» дни для собственной персоны. \r\n\r\nСпа-процедуры, хорошее кино, здоровая и полезная пища. Вот тогда я вспоминаю об этом чудо салате. Он очень полезен. Возможно, не всем он нравится, поскольку ключевым в нем является сельдерей. Он имеет специфический вкус и аромат. Однако в сочетании с другими ингредиентами он приобретает чрезвычайный оттенок. Очень полезный продукт. Сельдерей доступен круглый год. \r\n\r\nС виду неприметный, на вкус специфический. Но сколько в нем пользы. Узнавая о пользе какого-то продукта, я всячески пытаюсь использовать его в кулинарии и включать в рацион. В моей семье, не все в восторге от этого овоща. Но я не покладая сил его маскирую, добавляя в супы и другие блюда, когда при обработке его трудно заметить. Лично для меня сельдерей в свежем виде является вполне приемлемым продуктом. Поэтому салат с этой культурой я употребляю охотно. Главное это удачное сочетание компонентов как и в любом блюде. Именно поэтому я так люблю Вальдорфский салат.\r\n\r\nОчень часто мы используем зелень сельдерея. Добавляем в салаты, первые блюда и овощные блюда. Это очень ценная культура, так как содержит огромный полезный состав, и поэтому помогает как при различных заболеваниях, так и для профилактики в целом. Сегодня я буду использовать корень сельдерея, содержащий все эти полезные свойства, который еще и является противовоспалительным средством для организма. Поинтересуйтесь полезными свойствами сельдерея и этот салат станет и для вас одним из любимых. \r\n\r\nГотовка Вальдорфского салата - на раз-два. Он очень витаминизированный. Поэтому рекомендую его всем. Особенно тем представителям, которые следят за фигурой и правильным рационом. Этот салат нельзя назвать сытным, поэтому пообедать им вряд ли удастся. Хотя для людей, находящихся на диете это неплохим вариантом.\r\n\r\nЕсли есть несколько лишних минут, то приступаем к приготовлению.\r\n\r\nДля приготовления блюда нам понадобится: корень сельдерея, яблоки, виноград, грецкие орехи, листья салаты, лимон и майонез. Если у вас есть видение, еще какого-то продукта в этом блюде, конечно, вы можете экспериментировать и унифицировать салат под свой вкус.\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Вальдорфский салат");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Сельдерей 1 шт")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Соль по вкусу")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Лимон 1 / 4 шт")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Грецкий орех 0,5 кружки")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Листья салата 4 - 5 шт")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Яблоки 1 шт")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Майонез 5 ст.л.")));
            myList.ListItems.Add(listItem);


            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void Hamburger()
        {
            Run run1 = new Run("Гамбургер");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.MediumVioletRed;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../hamburg.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\n    Гамбургер состоит из булки и из котлеты. Все эти ингредиенты можно купить в магазине, чтобы не морочиться с приготовлением. Тогда время приготовления гамбургера будет вообще мизерным, и вам лишь останется пожарить котлету да сложить гамбургер. Но в качестве таких продуктов нельзя быть уверенным. Чтобы гамбургер принес больше пользы, можете сделать булочки и котлету сами.\r\n    Булочка выпекается из обычного дрожжевого теста, посыпанного сверху кунжутом. Так что берите любое дрожжевое тесто за основу и выпекайте пышные булочки, которые нужно будет лишь разделить ножом на половинки.\r\n    Перед выкладыванием слоев гамбургера поджарьте булочки на сухой сковороде.\r\n    Для гамбургеров отдают предпочтение говядине, потому что она не такая жирная, а также ее можно оставить внутри немного не прожаренной, чтобы сохранить сок. Если же выбираете свинину для котлеты в гамбургер, то учтите, что часть не должна быть жирной, лучше брать филейную часть, а также что котлета должна быть полностью прожаренной.\r\n    Кулинары утверждают, что для котлеты лучше мясо мелко порубить, сохраняя соки, но ленивые кулинары утверждают, что и способ пропустить через мясорубку очень даже подходит и совсем не хуже рубленых котлет.\r\n    Если решите печь булочки, то делайте их диаметром около 9 сантиметров, а котлету формируйте из сырого фарша чуть шире в диаметре. При термической обработке котлетка деформируется и ужарится, став немного меньше. Поэтому при жарке придавливайте немного ее посередине, чтобы она совсем не превратилась в шарик.\r\n    Замешивая фарш можно посолить его, а также приправить до формирования котлет. В них еще для вкуса можно добавить горчицу, мелкорубленный лук или протертые соленые огурчики. А можно котлету приправлять в процессе жарки с одной, а после другой стороны.\r\n    В фарш добавляют размоченный в молоке батон или яйцо, а можно и то, и другое, чтобы не сильно отбиваться от рецепта наших котлет.\r\n    Способы обжарки зависят от ваших возможностей. Это может быть гриль на улице, угли на костре, гриль-сковорода или обычная сковородка. На гриле, конечно же, вкуснее, так как котлетка пропитается запахом дымка.\r\n    Долго котлету обжаривать не стоит, чтобы она не стала сухой. Нам все же нужно сохранить внутри сок. Поэтому на каждой стороне обжаривайте ее примерно по 5 минут. Как только сок перестанет быть розоватым и станет прозрачным, котлета готова к употреблению.\r\n    При «строительстве» гамбургера соус можно намазывать на булочки, чтобы увлажнить их, а можно выкладывать на лист салата, если влажная булочка мешает употреблению.\r\n    В качестве соусов используют майонез, смесь майонеза и кетчупа, кетчуп и горчицу. Чтобы сделать гамбургер более полезной едой, можно эти соусы заменить на сметану или йогурт.\r\n    Все овощи нарезаются кружочками, чтобы удобно было распределить их на поверхности круглой котлеты.\r\n    Лук перед выкладкой можно замариновать в растворе уксуса, воды и сахара.\r\n    В зависимости от разновидности гамбургера добавляют разные ингредиенты, меняя начинки. Так, с кусочками сыра это будет уже чизбургер, а без мяса – веджибургер. Если мясо в котлете поменять на курицу, то гамбургер превратится в чизбургер или в фишбургер, если котлета будет рыбной.\r\n    Подавая гамбургер скрепите его слои, проткнув шпажкой или как в самых модных ресторанах грубым ножом с деревянной рукояткой.\r\n    С гамбургером часто подают картофель фри или любой другой жареный картофель.\r\n\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Гамбургер в домашних условиях");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Панировочные сухари 2 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Говяжий фарш 800 гр")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run(" Куриные яйца 1 шт")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Лук 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Помидоры 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Листья салата лист")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Огурцы 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Майонез по вкусу")));
            myList.ListItems.Add(listItem);

            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void Brauni()
        {
            Run run1 = new Run("Брауни");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.Brown;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../brauni.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\n    Изначально брауни готовили без шоколада и какао. Характерный цвет придавался благодаря коричневому сахару. Только ко второй половине XX века рецепт выпечки обрел тот вид, который мы хорошо знаем сейчас. Это типичный пример американской кухни – вкусно, просто и быстро.\r\n    Брауни с бананами – лишь одна из множества вариаций этой американской сладкой выпечки. Его можно готовить с ягодами (чаще всего это вишня), творожной прослойкой, орехами, начинкой из жидкого шоколада и т.д.\r\n    Классические брауни тонкие, высотой 2-3 см. Их можно есть и как пирожное, и как печенье, в зависимости от консистенции. В тесто добавляют чуть-чуть разрыхлителя или не добавляют его вовсе. В результате выпечка имеет хорошо узнаваемую плотную, слегка влажноватую структуру.\r\n    Если вы – очень большой любитель шоколада, можете при подаче полить кусочки брауни шоколадом. Интересно будет сочетать разные его виды. Например, в тесто добавить черный, а полить молочным.\r\n    Выпекать брауни допустимо в любой форме, круглой или квадратной. Однако квадратная удобнее, поскольку эту сладость подают нарезанной на небольшие квадратики.\r\n    Помните, что главное условие для хорошей выпечки – это качественные ингредиенты. И в первую очередь это касается шоколада. Выбирайте натуральный шоколад, с высоким содержанием какао-продуктов, без ароматизаторов и прочих химических добавок. Также не принято брать шоколад с наполнителями, будь то изюм, орехи или фруктовое пюре. Все это вы сможете добавить в тесто самостоятельно. Кондитеры используют специальный шоколад, но нам хватит и обычного из магазина. Внимательно читайте состав. В качественном продукте должно быть как минимум 30% какао-продуктов. И никаких ароматизаторов «Шоколад» - это явный признак суррогата.\r\n    Хотите приготовить выпечку тягучей и плотной консистенции? Тогда в ней должно быть много шоколада. А для придания бисквитной воздушности положите больше сахара и сливочного масла.\r\n    Перед смешиванием все ингредиенты нужно достать из холодильника, чтобы они прогрелись до комнатной температуры. Так тесто из них будет более мягким. А если вам некогда прогревать продукты (например, внезапно пришли гости), сложите их в миску и поставьте ее на 10 минут в теплую воду.\r\n    Важно достать брауни из духовки точно в момент приготовления. Передержите его, и выпечка получится пересушенной. Достанете рано – середина будет жидковатой.\r\n    Перед подачей дайте брауни остыть до комнатной температуры, а затем поставьте на 1-2 часа в холодильник. Тогда его вкус будет напоминать шоколадные трюфели.\r\n    Храните брауни в холодильнике не дольше 2-3 дней. Это скоропортящийся продукт. Замораживать его не стоит, вкус от этого портится.\r\n    Если выпечка в вашей духовке подгорает, обязательно поставьте под форму с брауни емкость с холодной водой.\r\n    При подаче обязательно как-то украсьте кусочки брауни. Можно просто полить их шоколадом, положить свежие ягоды, присыпать сахарной пудрой, добавить несколько листочков свежей мяты.\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Брауни");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Вода 2 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Пшеничная мука 4 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Куриные яйца 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Какао - порошок 1 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Шоколад черный 50 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сахар 3 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сливочное масло 70 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Шоколад молочный 50 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Для теста")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сахар 1 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Банан 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сметана 100 г.")));
            myList.ListItems.Add(listItem);

           FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void Beefstake()
        {
            Run run1 = new Run("Бифштекс");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.Maroon;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../bifshteks.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\n    В данном рецепте описан рецепт приготовления рубленого бифштекса – это один из разновидностей рецепта. Приготовить можно также бифштекс из цельной вырезки. Мясо должно быть нарезано поперек волокон кусками толщиной 2,5-3 см. Отбейте их до толщины 2 см. Отбивайте слегка, чтобы кусок оставался цельным. Натрите мясо перцем и солью со всех сторон. Жарьте с двух сторон на хорошо разогретой сковороде без масла по 3-4 минуты. Если хотите полностью прожаренный бифштекс, положите его в форму, влейте немного воды, закройте фольгой и доведите до готовности в духовом шкафу.\r\n    Если бифштекс готовят из цельного куска мяса, его нужно предварительно прогреть примерно до комнатной температуры и обтереть насухо, удалив с поверхности всю воду. Перед обжариванием мясо смазывают оливковым или рафинированным подсолнечным маслом. В саму сковороду подсолнечное масло или другой жир не добавляют никогда. Это позволяет быстро получить ту самую мясную корочку.\r\n    Традиционно бифштекс – это один из подвидов стейка. Существует три основных разновидности бифштекса: из вырезки, из рубленого и с отбитого мяса. Как и стейк, это блюдо имеет разные степени прожарки – от слабой с кровью до полной. В США приготовленные на гриле бифштексы из рубленого мяса часто используют для гамбургеров, как и котлеты.\r\n    Приготовленный на гриле бифштекс часто называют просто барбекю. Если он сделан из рубленого мяса, то именуется салисбурским или гамбургским. А есть еще и мясо в кляре. Для любителей оригинальности существует татарский бифштекс. Он не жарится, не запекается, а только прогревается и подается теплым. Такое сырое мясо едят с большим количеством приправ и острыми соусами. Конечно, говядина для этого блюда должна быть самой качественной.\r\n    Для качественного бифштекса нужно выбирать самое мягкое и сочное мясо. Идеальный вариант – мясо с бедер и сухожилий. Конечно, наличие сухожилий и пленок не допускается. Также очень желательно покупать мясо молодых животных. Чем старше корова, тем жестче говядина. Ее сложно сделать мягкой даже при длительном тушении, не говоря уже про быстрое обжаривание. Опытные повара знают, что для стейка и бифштекса нужно мясо именно молодых животных.\r\n    Главный инструмент для рубленого бифштекса – широкий, достаточно длинный, хорошо наточенный нож. Убедитесь, что его лезвие очень острое. Только так вы сможете быстро и без особых усилий нарезать говядину на мелкие кусочки.\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Бифштекс");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Сливочное масло 30 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Куриные яйца 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Лук 100 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Соль")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Говядина 300 г.")));
            myList.ListItems.Add(listItem);

            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void BananaCake()
        {
            Run run1 = new Run("Банановый кекс");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.LightGoldenrodYellow;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../bananacake.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\n    Уделим немного внимания разным формам для кексов. Они могут быть прямоугольными или круглыми, из разных материалов. Обычные металлические формы нужно смазывать маслом и посыпать сухарями (манкой), чтобы избежать прилипания. Прямоугольные формы для этих же целей выстилают пергаментом. Круглые выстелить сложно, пергамент комкается. Формы с антипригарным покрытием по инструкции можно и не смазывать, но я бы все же советовал использовать масло. Самыми удобными лично для меня являются силиконовые формы. Их можно разве что немного смазать маслом, и выпечка вынимается без проблем.\r\n    Чтобы приготовить мраморный кекс, нужно разделить готовое жидкое тесто на две половины, и во вторую добавить немного какао. В результате часть теста будет светлой, а часть коричневой. Вылейте в форму сначала один слой, затем второй и слегка перемешайте. После выпекания кекс будет иметь интересные узоры.\r\n    Для кекса нужно выбирать самые спелые бананы, мягкие и сладкие. Отлично подойдут перезрелые плоды с уже потемневшей кожурой. Их, кстати, часто можно купить со скидкой. Зеленые, недозрелые бананы жесткие, плохо превращаются в пюре. По вкусу они пресные из-за низкого содержания сахара.\r\n    Бананы в тесте хорошо сочетаются с измельченными грецкими или лесными орехами, корицей, кусочками сухофруктов, цукатов. Для украшения подойдет сахарная пудра, растопленный шоколад, глазурь. В Соединенных Штатах кексы зачастую специально пропитывают ликером или ромом, чтобы сделать вкус более насыщенным.\r\n    Для разнообразия часть муки (не более трети) вы можете заменить измельченными овсяными хлопьями.\r\n    Количество бананов влияет на конечную консистенцию выпечки. Если добавить много пюре, вкус будет более выраженным, но консистенция получится влажноватой. Меньше пюре – вкус менее выраженный, но консистенция получается пышной. Помните, что чем плотнее тесто, тем больше разрыхлителя нужно использовать. В описанном ниже рецепте используются два банана. Обратите внимание на тесто – оно влажноватое и довольно плотное. Для придания ему пышности уменьшите количество бананового пюре и добавьте больше разрыхлителя.\r\n    Чтобы получить более пористую структуру, взбейте отдельно белки с сахаром до получения белой пенистой массы. Добавьте в тесто после муки. Сливочное масло не растапливайте, а перетирайте с сахаром.\r\n    Чем больше в кексе сдобы, тем больше разрыхлителя нужно для придания ему пышности. Тяжелые ингредиенты, такие как масло, яйца, молоко, банановое пюре, поднимаются довольно сложно.\r\n    Для вегетарианцев готовить кекс можно по такому же рецепту, какой описан ниже. Только яйцо в таком случае не добавляется, молоко заменяется водой (можно с добавлением сиропа или компота), а вместо сливочного масла используется растительное. Вкус получается отличным, в пост – как раз то, что нужно.\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Банановый кекс");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Растительное масло 50 мл.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Молоко 100 мл.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Куриные яйца 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сахар 3 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Пшеничная мука 200 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Банан 2 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Разрыхлитель теста 2 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Шоколад молочный 50 г.")));
            myList.ListItems.Add(listItem);

            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void PigBones()
        {
            Run run1 = new Run("Ароматные свиные ребрышки в меду");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.Red;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../bones.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\n    Ребрышки хороши в любом виде: тушеные - для домашней семейной трапезы, запеченные – для праздничного застолья, а традиционный американский способ их приготовления – на углях на решетке, когда на мясе остаются поджаристые подпалины темного цвета и оно приобретает аромат дыма, – удовлетворит вкус любого гурмана. Очень сильное влияние на вкус и внешний вид блюда окажет выбранный соус. Рецепт, который мы вам предлагаем, позволит приготовить изумительно сочные и аппетитные свиные ребрышки.\r\n    На выходе у вас получится примерно 9 или 10 порций. Подайте их к столу с легким гарниром, например с запеченными овощами. Вашей семье или гостям остается только облизывать пальцы и восхищаться вашим непревзойденным кулинарным талантом.\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Ароматные свиные ребрышки в меду");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Лук Одна крупная")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Чеснок 5 зубцов")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Свиные ребра 1,5 кг.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Соевый соус 1 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Лавровый лист 5 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Мед 2 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Горчица 2 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Перец 1 ч.л.")));
            myList.ListItems.Add(listItem);

            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
        private void Pancakes()
        {
            Run run1 = new Run(" Американские панкейки на молоке ");
            Paragraph paragraph1 = new Paragraph(new Bold(run1));
            paragraph1.FontSize = 30;
            paragraph1.TextAlignment = TextAlignment.Center;
            paragraph1.Foreground = Brushes.Chocolate;
            Paragraph paragraph2 = new Paragraph();

            Image img = new Image();
            BitmapImage bimg = new BitmapImage();
            bimg.BeginInit();
            bimg.UriSource = new Uri("../../../Pancake.jpg", UriKind.Relative);
            bimg.EndInit();
            img.Source = bimg;
            BlockUIContainer block = new BlockUIContainer(img);
            Figure fig = new Figure(block);
            fig.Width = new FigureLength(300);
            fig.HorizontalAnchor = FigureHorizontalAnchor.ContentLeft;

            Run run2 = new Run();
            run2.Text = "\r\n    Это традиционное блюдо американцев и канадцев на завтрак. Такие блинчики мы часто видим в американских фильмах, они особенно и аппетитно выглядят. Сразу хочется сказать, что это в кино они такие красивые, а в действительности все не так просто. Ведь в самом деле - как достичь такой однородной аппетитной золотисто-бежевой корочки?\r\n    Мне всегда приходила мысль о том, что они имеют в себе или особенный рецепт, например необычный для нас ингредиент, или же сковородки у них специальные.\r\n    Оказалось все не так сложно. Даже наоборот – очень просто. Когда я впервые начала их готовить, то не надеялась на такой успешный результат. Меня все-таки смущала эта равномерная по цвету и структуре корочка. Я не верила, что можно вот так просто ее достичь. Ведь этим больше всего они меня и привлекли. Моей радости не было предела, когда всё получилось с первого блинчика...\r\n    По структуре нечто похожее на всем известные оладьи, а по вкусу на наши традиционные блины. Похожи, но все равно не такие. В частности это связано с тем, что оладьи готовятся на масле. Панкейки же, наоборот, готовятся на сухой сковородке без масла.\r\n    Наше ежедневное меню начинается с завтрака. Важно, чтобы он был вкусный и сытный и, что немаловажно, был прост в приготовлении с минимальными временными затратами.\r\n    Панкейки — это именно тот вариант, которым можно разнообразить наши утренние трапезы. Они понравятся абсолютно всей семье. Как и любые другие блины, их дополняют различными добавками. Это может быть варенье, сгущенное молоко, сметана или разнообразные сиропы. Очень вкусно поливать такие блинчики медом и посыпать сухофруктами, орешками.\r\n    Ну конечно, не только для завтрака можно приготовить эти прекрасные блины. Также уместными они будут на полдник. Или просто в любое время, когда захочется. Особенно их любят дети. Ведь их можно сочетать с любой сладкой начинкой. Наверное, вершиной наслаждения будет полить их шоколадом.\r\n    Обычно их готовят непосредственно перед употреблением. Но даже холодными они не теряют своей пышной и мягкой основы.\r\n    Рецепт приготовления прост и не заберет много времени. Что касается ингредиентов, то здесь абсолютно простой состав — скромный набор продуктов, который найдется у каждого на кухне: мука, молоко, яйца, сахар, сливочное масло, соль, сахар и порошок для печенья.\r\n    Приступим к приготовлению.\r\n";
            paragraph2.Inlines.Add(fig);
            paragraph2.Inlines.Add(run2);

            Run run3 = new Run("Ингредиенты для блюда: Американские панкейки на молоке");
            Paragraph paragraph3 = new Paragraph();
            paragraph3.FontSize = 18;
            paragraph3.TextAlignment = TextAlignment.Left;
            paragraph3.Inlines.Add(run3);

            List myList = new List();
            myList.FontFamily = new FontFamily("Segoe UI");
            myList.MarkerStyle = TextMarkerStyle.Circle;
            ListItem listItem = new ListItem(new Paragraph(new Run("Молоко 200 мл.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Мука 300 - 350 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сливочное масло 70 - 100 г.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Куриные яйца 1 шт.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Сахар 4 ст.л.")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Соль Щепотка")));
            myList.ListItems.Add(listItem);
            listItem = new ListItem(new Paragraph(new Run("Разрыхлитель теста 1 ч.л.")));
            myList.ListItems.Add(listItem);

            FlowDocument doc = new FlowDocument();
            doc.Blocks.Add(paragraph1);
            doc.Blocks.Add(paragraph2);
            doc.Blocks.Add(paragraph3);
            doc.Blocks.Add(myList);
            doc.FontFamily = new FontFamily("Segoe UI");
            DocReader.Document = doc;

        }
    }
}
