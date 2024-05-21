using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text.Json.Nodes;
using Newtonsoft.Json;
using ImageMagick;
using static System.Net.Mime.MediaTypeNames;

//set up directories
string appPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

if(!Directory.Exists(appPath + "//Bosses"))
{
    Directory.CreateDirectory(appPath + "//Bosses");
}

if(!Directory.Exists(appPath + "//Enemies"))
{
    Directory.CreateDirectory(appPath + "//Enemies");
}

if(!Directory.Exists(appPath + "//Characters"))
{
    Directory.CreateDirectory(appPath + "//Characters");
}

if(!Directory.Exists(appPath + "//Weapons"))
{
    Directory.CreateDirectory(appPath + "//Weapons");
}

//grab boss images
//url structure: https://dff.sp.mbga.jp/dff/static/lang/ab/battle_list/boss/204002/img_204002.png
// https://dff.sp.mbga.jp/dff/static/lang/ab/character/boss/204002/img_204002.png
//for each number from 100000 to 299999 (yikes is this a good idea?)
//can change this - 1xxxxx seems to have only few - follows same type of structure as below
//201xxx - FF1 
//202xxx - FF2
//203xxx - FF3
//204xxx - FF4
//205xxx - FF5
//206xxx - FF6
//207xxx - FF7
//208xxx - FF8
//209xxx - FF9
//210xxx - FF10
//211xxx - FF11
//212xxx - FF12
//213xxx - FF13
//214xxx - FF14
//215xxx - FF15
//227xxx - ???
//250xxx - Tactics
//251xxx - Tactics Advance
//260xxx - Type-0
//270xxx - ???
//290xxx - Event

//bosses
string urlPart1 = @"https://dff.sp.mbga.jp/dff/static/lang/ab/character/boss/";
string urlPart2 = @"/img_";
string urlPart3 = ".png";
string urlPart4 = ".json";
//string urlPart5 = ".sajson";
string urlPart5 = "_1.json";
DoFileLoops("boss");

//enemies
urlPart1 = @"https://dff.sp.mbga.jp/dff/static/lang/ab/character/enemy/img_";
urlPart2 = @"/img_";
urlPart3 = ".png";
urlPart4 = ".json";
urlPart5 = ".sajson";
//DoFileLoops("enemy");

//characters
urlPart1 = @"https://dff.sp.mbga.jp/dff/static/lang/ab/character/player/sab/";
urlPart2 = @"/img_chara";
urlPart3 = ".png";
urlPart4 = ".json";
urlPart5 = ".sajson";
//DoFileLoops("character");

//https://dff.sp.mbga.jp/dff/static/lang/ab/equip/weapon/100001/img_100001.png
//weapons
urlPart1 = @"https://dff.sp.mbga.jp/dff/static/lang/ab/equip/weapon/";
urlPart2 = @"/img_";
urlPart3 = ".png";
urlPart4 = ".json";
urlPart5 = ".sajson";
//DoWeaponLoop();

void DoFileLoops(string type) {
/*for (int i = 101000; i < 101300; i++) {
	GrabFile(i, type);
}

for (int i = 102000; i < 102300; i++) {
	GrabFile(i, type);
}

for (int i = 103000; i < 103300; i++) {
	GrabFile(i, type);
}

for (int i = 104000; i < 104300; i++) {
	GrabFile(i, type);
}

for (int i = 105000; i < 105300; i++) {
	GrabFile(i, type);
}

for (int i = 106000; i < 106300; i++) {
	GrabFile(i, type);
}

for (int i = 107000; i < 107300; i++) {
	GrabFile(i, type);
}

for (int i = 108000; i < 108300; i++) {
	GrabFile(i, type);
}

for (int i = 109000; i < 109300; i++) {
	GrabFile(i, type);
}

for (int i = 110000; i < 110300; i++) {
	GrabFile(i, type);
}

for (int i = 111000; i < 111300; i++) {
	GrabFile(i, type);
}

for (int i = 112000; i < 112300; i++) {
	GrabFile(i, type);
}

for (int i = 113000; i < 113300; i++) {
	GrabFile(i, type);
}

for (int i = 114000; i < 114300; i++) {
	GrabFile(i, type);
}

for (int i = 115000; i < 115300; i++) {
	GrabFile(i, type);
}

for (int i = 127000; i < 127300; i++) {
	GrabFile(i, type);
}

for (int i = 150000; i < 150300; i++) {
	GrabFile(i, type);
}

for (int i = 151000; i < 151300; i++) {
	GrabFile(i, type);
}

for (int i = 160000; i < 160300; i++) {
	GrabFile(i, type);
}

for (int i = 170000; i < 170300; i++) {
	GrabFile(i, type);
}

for (int i = 190000; i < 190300; i++) {
	GrabFile(i, type);
}*/



for (int i = 201000; i < 201300; i++) {
	GrabFile(i, type);
}

for (int i = 202000; i < 202300; i++) {
	GrabFile(i, type);
}

for (int i = 203000; i < 203300; i++) {
	GrabFile(i, type);
}

for (int i = 204000; i < 204300; i++) {
	GrabFile(i, type);
}

for (int i = 205000; i < 205300; i++) {
	GrabFile(i, type);
}

for (int i = 206000; i < 206300; i++) {
	GrabFile(i, type);
}

for (int i = 207000; i < 207300; i++) {
	GrabFile(i, type);
}

for (int i = 208000; i < 208300; i++) {
	GrabFile(i, type);
}

for (int i = 209000; i < 209300; i++) {
	GrabFile(i, type);
}

for (int i = 210000; i < 210300; i++) {
	GrabFile(i, type);
}

for (int i = 211000; i < 211300; i++) {
	GrabFile(i, type);
}

for (int i = 212000; i < 212300; i++) {
	GrabFile(i, type);
}

for (int i = 213000; i < 213300; i++) {
	GrabFile(i, type);
}

for (int i = 214000; i < 214300; i++) {
	GrabFile(i, type);
}

for (int i = 215000; i < 215300; i++) {
	GrabFile(i, type);
}

for (int i = 227000; i < 227300; i++) {
	GrabFile(i, type);
}

for (int i = 250000; i < 250300; i++) {
	GrabFile(i, type);
}

for (int i = 251000; i < 251300; i++) {
	GrabFile(i, type);
}

for (int i = 260000; i < 260300; i++) {
	GrabFile(i, type);
}

for (int i = 270000; i < 270300; i++) {
	GrabFile(i, type);
}

for (int i = 290000; i < 290300; i++) {
	GrabFile(i, type);
}



for (int i = 301000; i < 301300; i++) {
	GrabFile(i, type);
}

for (int i = 302000; i < 302300; i++) {
	GrabFile(i, type);
}

for (int i = 303000; i < 303300; i++) {
	GrabFile(i, type);
}

for (int i = 304000; i < 304300; i++) {
	GrabFile(i, type);
}

for (int i = 305000; i < 305300; i++) {
	GrabFile(i, type);
}

for (int i = 306000; i < 306300; i++) {
	GrabFile(i, type);
}

for (int i = 307000; i < 307300; i++) {
	GrabFile(i, type);
}

for (int i = 308000; i < 308300; i++) {
	GrabFile(i, type);
}

for (int i = 309000; i < 309300; i++) {
	GrabFile(i, type);
}

for (int i = 310000; i < 310300; i++) {
	GrabFile(i, type);
}

for (int i = 311000; i < 311300; i++) {
	GrabFile(i, type);
}

for (int i = 312000; i < 312300; i++) {
	GrabFile(i, type);
}

for (int i = 313000; i < 313300; i++) {
	GrabFile(i, type);
}

for (int i = 314000; i < 314300; i++) {
	GrabFile(i, type);
}

for (int i = 315000; i < 315300; i++) {
	GrabFile(i, type);
}

for (int i = 327000; i < 327300; i++) {
	GrabFile(i, type);
}

for (int i = 350000; i < 350300; i++) {
	GrabFile(i, type);
}

for (int i = 351000; i < 351300; i++) {
	GrabFile(i, type);
}

for (int i = 360000; i < 360300; i++) {
	GrabFile(i, type);
}

for (int i = 370000; i < 370300; i++) {
	GrabFile(i, type);
}

for (int i = 390000; i < 390300; i++) {
	GrabFile(i, type);
}



for (int i = 401000; i < 401300; i++) {
	GrabFile(i, type);
}

for (int i = 402000; i < 402300; i++) {
	GrabFile(i, type);
}

for (int i = 403000; i < 403300; i++) {
	GrabFile(i, type);
}

for (int i = 404000; i < 404300; i++) {
	GrabFile(i, type);
}

for (int i = 405000; i < 405300; i++) {
	GrabFile(i, type);
}

for (int i = 406000; i < 406300; i++) {
	GrabFile(i, type);
}

for (int i = 407000; i < 407300; i++) {
	GrabFile(i, type);
}

for (int i = 408000; i < 408300; i++) {
	GrabFile(i, type);
}

for (int i = 409000; i < 409300; i++) {
	GrabFile(i, type);
}

for (int i = 410000; i < 410300; i++) {
	GrabFile(i, type);
}

for (int i = 411000; i < 411300; i++) {
	GrabFile(i, type);
}

for (int i = 412000; i < 412300; i++) {
	GrabFile(i, type);
}

for (int i = 413000; i < 413300; i++) {
	GrabFile(i, type);
}

for (int i = 414000; i < 414300; i++) {
	GrabFile(i, type);
}

for (int i = 415000; i < 415300; i++) {
	GrabFile(i, type);
}

for (int i = 427000; i < 427300; i++) {
	GrabFile(i, type);
}

for (int i = 450000; i < 450300; i++) {
	GrabFile(i, type);
}

for (int i = 451000; i < 451300; i++) {
	GrabFile(i, type);
}

for (int i = 460000; i < 460300; i++) {
	GrabFile(i, type);
}

for (int i = 470000; i < 470300; i++) {
	GrabFile(i, type);
}

for (int i = 490000; i < 490300; i++) {
	GrabFile(i, type);
}



for (int i = 501000; i < 501300; i++) {
	GrabFile(i, type);
}

for (int i = 502000; i < 502300; i++) {
	GrabFile(i, type);
}

for (int i = 503000; i < 503300; i++) {
	GrabFile(i, type);
}

for (int i = 504000; i < 504300; i++) {
	GrabFile(i, type);
}

for (int i = 505000; i < 505300; i++) {
	GrabFile(i, type);
}

for (int i = 506000; i < 506300; i++) {
	GrabFile(i, type);
}

for (int i = 507000; i < 507300; i++) {
	GrabFile(i, type);
}

for (int i = 508000; i < 508300; i++) {
	GrabFile(i, type);
}

for (int i = 509000; i < 509300; i++) {
	GrabFile(i, type);
}

for (int i = 510000; i < 510300; i++) {
	GrabFile(i, type);
}

for (int i = 511000; i < 511300; i++) {
	GrabFile(i, type);
}

for (int i = 512000; i < 512300; i++) {
	GrabFile(i, type);
}

for (int i = 513000; i < 513300; i++) {
	GrabFile(i, type);
}

for (int i = 514000; i < 514300; i++) {
	GrabFile(i, type);
}

for (int i = 515000; i < 515300; i++) {
	GrabFile(i, type);
}

for (int i = 527000; i < 527300; i++) {
	GrabFile(i, type);
}

for (int i = 550000; i < 550300; i++) {
	GrabFile(i, type);
}

for (int i = 551000; i < 551300; i++) {
	GrabFile(i, type);
}

for (int i = 560000; i < 560300; i++) {
	GrabFile(i, type);
}

for (int i = 570000; i < 570300; i++) {
	GrabFile(i, type);
}

for (int i = 590000; i < 590300; i++) {
	GrabFile(i, type);
}



for (int i = 601000; i < 601300; i++) {
	GrabFile(i, type);
}

for (int i = 602000; i < 602300; i++) {
	GrabFile(i, type);
}

for (int i = 603000; i < 603300; i++) {
	GrabFile(i, type);
}

for (int i = 604000; i < 604300; i++) {
	GrabFile(i, type);
}

for (int i = 605000; i < 605300; i++) {
	GrabFile(i, type);
}

for (int i = 606000; i < 606300; i++) {
	GrabFile(i, type);
}

for (int i = 607000; i < 607300; i++) {
	GrabFile(i, type);
}

for (int i = 608000; i < 608300; i++) {
	GrabFile(i, type);
}

for (int i = 609000; i < 609300; i++) {
	GrabFile(i, type);
}

for (int i = 610000; i < 610300; i++) {
	GrabFile(i, type);
}

for (int i = 611000; i < 611300; i++) {
	GrabFile(i, type);
}

for (int i = 612000; i < 612300; i++) {
	GrabFile(i, type);
}

for (int i = 613000; i < 613300; i++) {
	GrabFile(i, type);
}

for (int i = 614000; i < 614300; i++) {
	GrabFile(i, type);
}

for (int i = 615000; i < 615300; i++) {
	GrabFile(i, type);
}

for (int i = 627000; i < 627300; i++) {
	GrabFile(i, type);
}

for (int i = 650000; i < 650300; i++) {
	GrabFile(i, type);
}

for (int i = 651000; i < 651300; i++) {
	GrabFile(i, type);
}

for (int i = 660000; i < 660300; i++) {
	GrabFile(i, type);
}

for (int i = 670000; i < 670300; i++) {
	GrabFile(i, type);
}

for (int i = 690000; i < 690300; i++) {
	GrabFile(i, type);
}


for (int i = 701000; i < 701300; i++) {
	GrabFile(i, type);
}

for (int i = 702000; i < 702300; i++) {
	GrabFile(i, type);
}

for (int i = 703000; i < 703300; i++) {
	GrabFile(i, type);
}

for (int i = 704000; i < 704300; i++) {
	GrabFile(i, type);
}

for (int i = 705000; i < 705300; i++) {
	GrabFile(i, type);
}

for (int i = 706000; i < 706300; i++) {
	GrabFile(i, type);
}

for (int i = 707000; i < 707300; i++) {
	GrabFile(i, type);
}

for (int i = 708000; i < 708300; i++) {
	GrabFile(i, type);
}

for (int i = 709000; i < 709300; i++) {
	GrabFile(i, type);
}

for (int i = 710000; i < 710300; i++) {
	GrabFile(i, type);
}

for (int i = 711000; i < 711300; i++) {
	GrabFile(i, type);
}

for (int i = 712000; i < 712300; i++) {
	GrabFile(i, type);
}

for (int i = 713000; i < 713300; i++) {
	GrabFile(i, type);
}

for (int i = 714000; i < 714300; i++) {
	GrabFile(i, type);
}

for (int i = 715000; i < 715300; i++) {
	GrabFile(i, type);
}

for (int i = 727000; i < 727300; i++) {
	GrabFile(i, type);
}

for (int i = 750000; i < 750300; i++) {
	GrabFile(i, type);
}

for (int i = 751000; i < 751300; i++) {
	GrabFile(i, type);
}

for (int i = 760000; i < 760300; i++) {
	GrabFile(i, type);
}

for (int i = 770000; i < 770300; i++) {
	GrabFile(i, type);
}

for (int i = 790000; i < 790300; i++) {
	GrabFile(i, type);
}



for (int i = 801000; i < 801300; i++) {
	GrabFile(i, type);
}

for (int i = 802000; i < 802300; i++) {
	GrabFile(i, type);
}

for (int i = 803000; i < 803300; i++) {
	GrabFile(i, type);
}

for (int i = 804000; i < 804300; i++) {
	GrabFile(i, type);
}

for (int i = 805000; i < 805300; i++) {
	GrabFile(i, type);
}

for (int i = 806000; i < 806300; i++) {
	GrabFile(i, type);
}

for (int i = 807000; i < 807300; i++) {
	GrabFile(i, type);
}

for (int i = 808000; i < 808300; i++) {
	GrabFile(i, type);
}

for (int i = 809000; i < 809300; i++) {
	GrabFile(i, type);
}

for (int i = 810000; i < 810300; i++) {
	GrabFile(i, type);
}

for (int i = 811000; i < 811300; i++) {
	GrabFile(i, type);
}

for (int i = 812000; i < 812300; i++) {
	GrabFile(i, type);
}

for (int i = 813000; i < 813300; i++) {
	GrabFile(i, type);
}

for (int i = 814000; i < 814300; i++) {
	GrabFile(i, type);
}

for (int i = 815000; i < 815300; i++) {
	GrabFile(i, type);
}

for (int i = 827000; i < 827300; i++) {
	GrabFile(i, type);
}

for (int i = 850000; i < 850300; i++) {
	GrabFile(i, type);
}

for (int i = 851000; i < 851300; i++) {
	GrabFile(i, type);
}

for (int i = 860000; i < 860300; i++) {
	GrabFile(i, type);
}

for (int i = 870000; i < 870300; i++) {
	GrabFile(i, type);
}

for (int i = 890000; i < 890300; i++) {
	GrabFile(i, type);
}



for (int i = 901000; i < 901300; i++) {
	GrabFile(i, type);
}

for (int i = 902000; i < 902300; i++) {
	GrabFile(i, type);
}

for (int i = 903000; i < 903300; i++) {
	GrabFile(i, type);
}

for (int i = 904000; i < 904300; i++) {
	GrabFile(i, type);
}

for (int i = 905000; i < 905300; i++) {
	GrabFile(i, type);
}

for (int i = 906000; i < 906300; i++) {
	GrabFile(i, type);
}

for (int i = 907000; i < 907300; i++) {
	GrabFile(i, type);
}

for (int i = 908000; i < 908300; i++) {
	GrabFile(i, type);
}

for (int i = 909000; i < 909300; i++) {
	GrabFile(i, type);
}

for (int i = 910000; i < 910300; i++) {
	GrabFile(i, type);
}

for (int i = 911000; i < 911300; i++) {
	GrabFile(i, type);
}

for (int i = 912000; i < 912300; i++) {
	GrabFile(i, type);
}

for (int i = 913000; i < 913300; i++) {
	GrabFile(i, type);
}

for (int i = 914000; i < 914300; i++) {
	GrabFile(i, type);
}

for (int i = 915000; i < 915300; i++) {
	GrabFile(i, type);
}

for (int i = 927000; i < 927300; i++) {
	GrabFile(i, type);
}

for (int i = 950000; i < 950300; i++) {
	GrabFile(i, type);
}

for (int i = 951000; i < 951300; i++) {
	GrabFile(i, type);
}

for (int i = 960000; i < 960300; i++) {
	GrabFile(i, type);
}

for (int i = 970000; i < 970300; i++) {
	GrabFile(i, type);
}

for (int i = 990000; i < 990300; i++) {
	GrabFile(i, type);
}
}

void DoWeaponLoop() {
	for (int i = 100000; i < 101300; i++) {
		GrabFile(i, "weapon");
	}
}

void GrabFile(int i, string type) {
	string urlToCheck = "";
	string jsonUrl = "";
	string sajsonUrl = "";
	string downloadDir = "";
	if (type == "boss") {
		//https://dff.sp.mbga.jp/dff/static/lang/ab/character/boss/106130/img_106130.png
		urlToCheck = urlPart1 + i + urlPart2 + i + urlPart3;
		jsonUrl = urlPart1 + i + urlPart2 + i + urlPart4;
		sajsonUrl = urlPart1 + i + "//" + i + urlPart5;
		downloadDir = "//Bosses//";
	} else if (type == "enemy") {
		//https://dff.sp.mbga.jp/dff/static/lang/ab/character/enemy/img_108006.png
		urlToCheck = urlPart1 + i + urlPart3;
		jsonUrl = urlPart1 + i + urlPart4;
		sajsonUrl = urlPart1 + i + urlPart5;
		downloadDir = "//Enemies//";
	} else if (type == "character") {
		// https://dff.sp.mbga.jp/dff/static/lang/ab/character/player/sab/100001/img_chara.png
		urlToCheck = urlPart1 + i + urlPart2 + urlPart3;
		jsonUrl = urlPart1 + i + urlPart2 + urlPart4;
		sajsonUrl = urlPart1 + i + urlPart2 + urlPart5;
		downloadDir = "//Characters//";
	} else if (type == "weapon") {
		// https://dff.sp.mbga.jp/dff/static/lang/ab/equip/weapon/100001/img_100001.png
		urlToCheck = urlPart1 + i + urlPart2 + i + urlPart3;
		jsonUrl = urlPart1 + i + urlPart2 + i + urlPart4;
		sajsonUrl = urlPart1 + i + urlPart2 + i + urlPart5;
		downloadDir = "//Weapons//";
	}
	string imgName = "img_" + i + urlPart3;
	string jsonName = "img_" + i + urlPart4;
	string sajsonName = i + "_1.json";
	string imgOutName = "img_" + i + "_assembled";
	//build the url string
	
	//use HttpWebRequest to check if result is a png
	HttpWebRequest myReq = (HttpWebRequest) WebRequest.Create(urlToCheck);
	//if yes
	myReq.Method = "HEAD";
	var isImage = false;
	try {
		using (var resp = myReq.GetResponse())
			{
					isImage = resp.ContentType.ToLower(CultureInfo.InvariantCulture)
										 .StartsWith("image/");
			}
		} catch (WebException ex) {
			Console.WriteLine("No data for url: " + urlToCheck);
		}
	string jsonText = "";
	if (isImage) {
		//get and store the image in the proper directory
		using (WebClient client = new WebClient())
		{
			client.DownloadFile(new Uri(urlToCheck), appPath + downloadDir + imgName);
			//get the associated json file and save that as well
		}

		bool jsonRetrieved = true;

		using (WebClient client = new WebClient())
		{
			//get the associated json file and save that as well
			try {
					client.DownloadFile(new Uri(sajsonUrl), appPath + downloadDir + sajsonName);
				} catch (WebException ex) {
					Console.WriteLine("SAJSON retrieval failed.");
					//jsonRetrieved = false;
				}
			
		}

		using (WebClient client = new WebClient())
		{
			//get the associated json file and save that as well
			try {
					client.DownloadFile(new Uri(jsonUrl), appPath + downloadDir + jsonName);
				} catch (WebException ex) {
					Console.WriteLine("JSON retrieval failed.");
					jsonRetrieved = false;
				}
			

			//process the json and image data
			//ProcessImageData(appPath + downloadDir + jsonName, appPath + downloadDir + imgName, appPath + downloadDir + imgOutName, type, jsonRetrieved);
		}
	}
}

//load the json file
string LoadJson(string jsonFilename)
{
  using (StreamReader r = new StreamReader(jsonFilename))
  {
    return r.ReadToEnd();
    //List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
  }
}

void ProcessImageData(string jsonFilename, string imgPath, string imgOutPath, string type, bool hasJson) {
	if (!hasJson) {
		return;
	}

	string json = LoadJson(jsonFilename);
	dynamic parsedObject = JsonConvert.DeserializeObject(json);

	//information needed for processing the image
	//rectangles for individual parts
	List<Rectangle> srcRectList = new List<Rectangle>();
	List<Rectangle> destRectList = new List<Rectangle>();
	int resultWidth = 0;
	int resultHeight = 0;

	Bitmap sourceImage = (Bitmap)System.Drawing.Image.FromFile(imgPath);

	int imgCount = 0;
	int imgVariants = 0;

	List<Bitmap> resultList = new List<Bitmap>();
	//create a list of the names so they can be checked over to see how many result images will be needed
	List<string> frameNames = new List<string>();

	foreach (dynamic entry in parsedObject)
	{
		
		string name = entry.Name; //frames (first run)
		dynamic value = entry.Value; //value of everything else except meta (first run)
		if (name == "frames") {
			//this loop will have the whatever.png subentry
			
			foreach (dynamic frameImg in value) {
				frameNames.Add(frameImg.Name);
			}

			string imgID = "";
			//string imgPart = "";
			string imgVariant = "";

			//get the image and variant counts
			foreach (string frameName in frameNames) {
				string[] namePartsTemp = frameName.Split('_');
				if (imgID == "") {
					imgID = namePartsTemp[0];
				} else if (imgID != namePartsTemp[0]) {
					imgCount += 1;
				}
				if (namePartsTemp.Length > 2 && imgVariant == "") {
					imgID = namePartsTemp[0];
				} else if (namePartsTemp.Length > 2 &&  imgVariant != namePartsTemp[2]) {
					imgVariants += 1;
				}
			}
			
			//dynamic sourceSize;
			/*foreach (dynamic frameImg in value) {
				//foreach (dynamic frameInfo in frameImg.Value) {
					dynamic srcSizeTemp = frameImg.Value;
					sourceSize = srcSizeTemp.sourceSize;
					//sourceSize = frameImg.sourceSize.Value;
					//add the initial image
					resultList.Add(new Bitmap((int)sourceSize.w.Value, (int)sourceSize.h.Value));

					if (imgCount > 1) {
						//check each image info for sourceSize
						//if sourceSize is different than the current one
						if (frameImg.sourceSize.Value != sourceSize) {
							//update it
							sourceSize = frameImg.sourceSize.Value;
							//add a new image
							resultList.Add(new Bitmap((int)sourceSize.w.Value, (int)sourceSize.h.Value));
						}
					}
					if (imgVariants > 1) {
						string[] namePartsTemp = frameImg.Name.Split('_');
						//check each image info for sourceSize
						//if sourceSize is different than the current one
						if (namePartsTemp.Length > 2) {
							//add a new image
							resultList.Add(new Bitmap((int)frameImg.sourceSize.Value.w.Value, (int)frameImg.sourceSize.Value.h.Value));
						}
					}
				//}
			}*/

			//I'm going to assume there will only be variants or multiple images and not both - this might be a mistake

			foreach (dynamic frameImg in value) {
				string frameImgName = frameImg.Name;

				dynamic frameImgValue = frameImg.Value;

				//frame rectangle within the image
				int[] frameDimensions = new int[4];

				dynamic frameImgRect = frameImgValue.frame;
				int rectCounter = 0;
				foreach (int rectVal in frameImgRect) {
					frameDimensions[rectCounter] = rectVal; 
					rectCounter++;
				}

				Rectangle rect = new Rectangle(frameDimensions[0], frameDimensions[1], 
																				frameDimensions[2], frameDimensions[3]);
				srcRectList.Add(rect);

				int[] sourceDimensions = new int[4];
				dynamic spriteSourceRect = frameImgValue.spriteSourceSize;
				rectCounter = 0;
				foreach (int rectVal in spriteSourceRect) {
					sourceDimensions[rectCounter] = rectVal; 
					rectCounter++;
				}

				Rectangle srcRect = new Rectangle(sourceDimensions[0], sourceDimensions[1], 
																				sourceDimensions[2], sourceDimensions[3]);
				destRectList.Add(srcRect);

				//result image size
				dynamic spriteResultSize = frameImgValue.sourceSize;
				if (spriteResultSize.w >= resultWidth) {
					resultWidth = spriteResultSize.w;
				}
				if (spriteResultSize.h >= resultHeight) { resultHeight = spriteResultSize.h;}
			}
		}
	}

	//Bitmap resultImage = new Bitmap(resultWidth, resultHeight);
	/*int positionCounter = -1;
	string lastImageID = "";*/

	var resultImage = new MagickImage(MagickColors.Transparent, resultWidth, resultHeight);

	for (int i = 0; i < srcRectList.Count; i++) {
		/*string[] namePartsTemp = frameNames[i].Split('_');
		string currentImageID = namePartsTemp[0];
		if (currentImageID != lastImageID) {
			positionCounter++;
		}*/
		//lastImageID = currentImageID;
		//frame names should share the same order as these lists
		//int copyCount = 1;
		//if (!IsVariant(frameNames[i])) {
		//	copyCount += imgVariants;
		//}*/
		Rectangle srcRect = srcRectList[i];
		Rectangle destRect = destRectList[i];
		//for (int j = 0; j < copyCount; j++) {
			//CopyRegionIntoImage(sourceImage, srcRect, resultList[j], destRect);
		//}

		Bitmap temp = new Bitmap(destRect.Width, destRect.Height);
		CopyRegionIntoImage(sourceImage, srcRect, ref temp, destRect);
		temp.Save(imgOutPath + ".png");

		//create image to add as a new layer to the result image
		var layerImage = new MagickImage(imgOutPath + "_temp.png");

		//resultImage.Composite(layerImage, destRect.X, destRect.Y, CompositeOperator.Over);

		//CopyRegionIntoImage(sourceImage, srcRect, ref resultImage, destRect);
		/*if (type == "enemy") {
			break;
		}*/
	}

	/*int counter = 1;
	foreach (Bitmap img in resultList) {
		img.Save(imgOutPath + counter + ".png");
		counter++;
	}*/
	resultImage.Write(imgOutPath);
	File.Delete(imgOutPath + "_temp.png");
}

bool IsVariant(string frameName) {
	string[] namePartsTemp = frameName.Split('_');
	if (namePartsTemp.Length == 3) {
		return true;
	} else {
		return false;
	}
}

static void CopyRegionIntoImage(Bitmap srcBitmap, Rectangle srcRegion, ref Bitmap destBitmap, Rectangle destRegion)
    {
        using (Graphics grD = Graphics.FromImage(destBitmap))            
        {
            grD.DrawImage(srcBitmap, destRegion, srcRegion, GraphicsUnit.Pixel);                
        }
    }