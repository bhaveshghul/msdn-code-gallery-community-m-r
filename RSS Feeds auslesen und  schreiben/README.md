# RSS Feeds auslesen und  schreiben
## Requires
- Visual Studio 2012
## License
- Apache License, Version 2.0
## Technologies
- RSS
- LINQ to XML
- Realy Simple Syndication
- XML to LINQ
## Topics
- RSS
- LINQ
- Realy Simple Syndication
- XML to LINQ
- LING to XML
- XDocument
- XElement
- XAttribute
## Updated
- 10/24/2012
## Description

<h1>Einleitung</h1>
<p><strong>Hinweis:</strong> Der Code zum auslesen und schreiben befindet sich komplett Im downlaodbaren Beispiel.</p>
<p><strong>Hinweis: </strong>Das Beispiel enth&auml;lt die Klassen zum lesen von RSS- als auch die zum lesen vonAtom Feeds.<strong>&nbsp;</strong></p>
<p>Einige werden sicherlich RSS oder Atom Feeds abbonniert haben. Dieser Artikel beschreibt nur das lesen und schreiben von RSS Feeds.</p>
<p>Wenn Sie Atom Feeds auslesen/schreiben wollen, so finden Sie dazu <a href="http://code.msdn.microsoft.com/Atom-Feeds-auslesen-und-f7628096" target="_blank">
hier</a> ein Beispiel.</p>
<p>RSS Feeds sind XML basierte &quot;Zeitungen&quot; diese enthalten mehrere Artikel, mit einer Beschreibung, Kategorie, dem Autor usw....</p>
<p>Diese werden oft in Blogs und auf Webseiten benutzt:<br>
<br>
http://www.microsoft.com/germany/msdn/rss/DC_VisualStudio.xml<br>
http://social.msdn.microsoft.com/Forums/de-DE/visualcsharpde/threads?outputAs=rss<br>
usw.</p>
<p>Zum lesen ben&ouml;tigen Sie einen Feed Reader. Beispiele daf&uuml;r sind moderne Brwoser wie Internet Explorer 9, Mozilla Firefox 15 aber auch die meisten EMail Programme wie Thunderbiord und Outlook unterst&uuml;tzen das lesen dieser Feeds.</p>
<h1><span>Wie ist ein RSS Feed aufgebaut?<br>
</span></h1>
<p><em>Ein RSS Feed macht von der XML Syntax gebrauch. Als Root Element kommt das Element &quot;rss&quot;, in diesem ist nur ein Element, Namens &quot;channel&quot;. Dort sind nun algemeine Daten bez&uuml;glich des Feeds zu finden:
</em></p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Skript bearbeiten</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xml</span>

<div class="preview">
<pre class="xml"><span class="xml__tag_start">&lt;?xml</span>&nbsp;<span class="xml__attr_name">version</span>=<span class="xml__attr_value">&quot;1.0&quot;</span>&nbsp;<span class="xml__attr_name">encoding</span>=<span class="xml__attr_value">&quot;utf-8&quot;</span><span class="xml__tag_start">?&gt;</span>&nbsp;
<span class="xml__tag_start">&lt;rss</span>&nbsp;<span class="xml__attr_name">version</span>=<span class="xml__attr_value">&quot;2.0&quot;</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;channel</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;generator</span><span class="xml__tag_start">&gt;</span>KoopakillerFeed<span class="xml__tag_end">&lt;/generator&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;title</span><span class="xml__tag_start">&gt;</span>Title<span class="xml__tag_end">&lt;/title&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;description</span><span class="xml__tag_start">&gt;</span>Kurze&nbsp;Beschreibung<span class="xml__tag_end">&lt;/description&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;link</span><span class="xml__tag_start">&gt;</span>test.htm<span class="xml__tag_end">&lt;/link&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;copyright</span><span class="xml__tag_start">&gt;</span>Copright<span class="xml__tag_end">&lt;/copyright&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;image</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;url</span><span class="xml__tag_start">&gt;</span>http://koopakiller.ko.ohost.de/images/bg.png<span class="xml__tag_end">&lt;/url&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;title</span><span class="xml__tag_start">&gt;</span>Title<span class="xml__tag_end">&lt;/title&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;link</span><span class="xml__tag_start">&gt;</span>test.htm<span class="xml__tag_end">&lt;/link&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_end">&lt;/image&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;language</span><span class="xml__tag_start">&gt;</span>de-de<span class="xml__tag_end">&lt;/language&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;pubDate</span><span class="xml__tag_start">&gt;</span>Sat,&nbsp;20&nbsp;Oct&nbsp;2012&nbsp;16:29:43&nbsp;GMT<span class="xml__tag_end">&lt;/pubDate&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;managingEditor</span><span class="xml__tag_start">&gt;</span>Autor<span class="xml__tag_end">&lt;/managingEditor&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;category</span>&nbsp;<span class="xml__attr_name">domain</span>=<span class="xml__attr_value">&quot;test&quot;</span><span class="xml__tag_start">&gt;</span>fsdf<span class="xml__tag_end">&lt;/category&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;category</span><span class="xml__tag_start">&gt;</span>sdafsdf<span class="xml__tag_end">&lt;/category&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;...</pre>
</div>
</div>
</div>
<table border="1" cellspacing="0" cellpadding="0" width="607" height="336">
<tbody>
<tr>
<td width="205" valign="top">
<p>generator</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Der Generator, mit dem der Feed erstellt wurde.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>title</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Ben&ouml;tigt</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Der Titel des Feeds.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>description</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Ben&ouml;tigt</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Eine kurze Beschreibung des Feeds.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>link</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Ben&ouml;tigt</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Der Link zur Webseite.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>copyright</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Das Copyright.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>image &gt; url</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Die Url eines Bildes des Feeds.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>image &gt; title</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Der Titel des Bildes.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>image &gt; link</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Der Link, auf den das Bild verweist.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>language</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Die Sprache, in der der Feed verfasst ist.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>pubDate</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Das Ver&ouml;ffentlichungsdatum.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>managingEditor</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Der Autor des Feeds, bzw. der Webmaster, der f&uuml;r den Feed verantwortlich ist.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>category</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Kategorien, zu denen der Feed Arikel enth&auml;lt. Hiervon k&ouml;nnen mehrere Angegeben werden.</p>
</td>
</tr>
<tr>
<td width="205" valign="top">
<p>item</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Ohne macht es keinen Sinn</p>
</td>
<td width="205" valign="top">
<p>&nbsp;Die Verschiedenen Artikel. Diese k&ouml;nnen ebenfalls mehrfach vorkommen. Dazu sp&auml;ter mehr.</p>
</td>
</tr>
</tbody>
</table>
<p>Die Items (Artikel) selber k&ouml;nnen wieder mehrere Attribute aufweisen:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>XML</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Skript bearbeiten</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">xml</span>

<div class="preview">
<pre class="xml"><span class="xml__tag_start">&lt;item</span><span class="xml__tag_start">&gt;&nbsp;
</span>&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;title</span><span class="xml__tag_start">&gt;</span>Neuer&nbsp;Eintrag<span class="xml__tag_end">&lt;/title&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;description</span><span class="xml__tag_start">&gt;</span><span class="xml__unParsedSection">&lt;![CDATA[&lt;p&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;Inhalt&lt;/p&gt;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;]]&gt;</span><span class="xml__tag_end">&lt;/description&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;link</span><span class="xml__tag_start">&gt;</span>test.de/news.html<span class="xml__tag_end">&lt;/link&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;author</span><span class="xml__tag_start">&gt;</span>Autor<span class="xml__tag_end">&lt;/author&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;guid</span>&nbsp;&nbsp;<span class="xml__attr_name">isPermaLink</span>=<span class="xml__attr_value">&quot;false&quot;</span><span class="xml__tag_start">&gt;</span>c3a79b10-29a8-4e7b-9ad8-586ceb1f8160<span class="xml__tag_end">&lt;/guid&gt;</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;<span class="xml__tag_start">&lt;pubDate</span><span class="xml__tag_start">&gt;</span>Sat,&nbsp;20&nbsp;Oct&nbsp;2012&nbsp;11:19:35&nbsp;GMT<span class="xml__tag_end">&lt;/pubDate&gt;</span>&nbsp;
<span class="xml__tag_end">&lt;/item&gt;</span></pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;
<table border="1" cellspacing="0" cellpadding="0">
<tbody>
<tr>
<td width="83" valign="top">
<p>title</p>
</td>
<td width="114" valign="top">
<p>&nbsp;Ben&ouml;tigt</p>
</td>
<td width="418" valign="top">
<p>&nbsp;Der Titel, welcher im Reader als &Uuml;berschrift angezeigt wird.</p>
</td>
</tr>
<tr>
<td width="83" valign="top">
<p>description</p>
</td>
<td width="114" valign="top">
<p>&nbsp;Ben&ouml;tigt</p>
</td>
<td width="418" valign="top">
<p>&nbsp;Das ist der Inhalt des Feeds. Zu diesem Erz&auml;hle ich sp&auml;ter mehr.</p>
</td>
</tr>
<tr>
<td width="83" valign="top">
<p>link</p>
</td>
<td width="114" valign="top">
<p>&nbsp;Ben&ouml;tigt</p>
</td>
<td width="418" valign="top">
<p>&nbsp;Der Link zum Vollst&auml;ndigen Inhalt / zur Webseite.</p>
</td>
</tr>
<tr>
<td width="83" valign="top">
<p>author</p>
</td>
<td width="114" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="418" valign="top">
<p>&nbsp;Der Autor des Feeds.</p>
</td>
</tr>
<tr>
<td width="83" valign="top">
<p>guid</p>
</td>
<td width="114" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="418" valign="top">
<p>&nbsp;Eine eindeutige Zeichenkombination, anhand der Reader erkennen kann ob man einen Artikel schon gelsen hat. Darum solltesn diese guid's auch nur einmal pro Feed vorkommen. (Es muss sich um keine g&uuml;ltige guid handeln, es kann auch einfach der titel
 o.&auml;. sein)</p>
</td>
</tr>
<tr>
<td width="83" valign="top">
<p>pubDate</p>
</td>
<td width="114" valign="top">
<p>&nbsp;Optional</p>
</td>
<td width="418" valign="top">
<p>&nbsp;Das Ver&ouml;ffentlichungsdatum des Artikels.</p>
</td>
</tr>
</tbody>
</table>
</div>
<p>Der gro&szlig;e Nachteil von RSS Feeds ist, das der Reader nicht wirklich eine M&ouml;glichkeit hat zu unterscheiden ob der Inhalt nun ein reiuner Text oder doch ein aufw&auml;ndig formatiertes HTML Dokument ist. Der Reader muss somit raten.</p>
<p>Der Inahlt sollte in einem CDATA stehen bzw. mittels den XML ersetzungen formatiert werden:</p>
<p>&lt;test&gt;...&lt;test&gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &gt;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &amp;lt;test&amp;gt;...&amp;lt;test&amp;gt;</p>
<p>F&uuml;r weitere Informationen findet <a href="http://www.w3schools.com/rss/rss_reference.asp" target="_blank">
hier</a> ein vollst&auml;ndigerere Referenz. Meine Klasse unterst&uuml;tzt alles au&szlig;er dem
<em>cloud </em>und dem <em>rating </em>Element.</p>
<p><span style="font-size:20px; font-weight:bold">Das Klassenkonstrukt<br>
</span></p>
<p><em>Da meine Klassen auch f&uuml;r den Gebrauch mit Atom Feeds gedacht sind, gibt es einige scheinbar (auch nicht aufgef&uuml;hrte) nicht ben&ouml;tigte Klassen.</em></p>
<p><em>Klassen:</em></p>
<ul>
<li>RSSFeed<em> - Eine Klasse, welche einen RSS Feed einlesen sowie bearbeiten und speichern kann.<br>
</em></li><li>RSSFeedArticle <em>- Ein Artikel, welcher zu einem RSS Feed (RSSFeed.Artuicles) hinzugef&uuml;gt werden kann.<br>
</em></li><li>RSSFeedArticleEnclosure -<em> Ein Medienanhang f&uuml;r einen RSS Artikel.</em>
</li><li>RSSFeedArticleGuid -<em> Eine eindeutige ID, mit welcher der Artikel im Feed indentifiziert werden kann.</em>
</li><li>RSSFeedArticleSource - <em>Eine Quelle f&uuml;r einen RSS Feed Artikel.</em> </li><li>RSSFeedCategory - <em>Eine Kategorie, welche einem Feed oder einem Artikel zugewiesen werden kann (*.Categories).</em>
</li><li>RSSFeedImage - <em>Ein Bild f&uuml;r den RSS Feed mit Url, Titel und Name.</em>
</li><li>RSSFeedTextInput - <em>Ein Optionales Eingabefeld in einem RSSFeed.</em> </li></ul>
<h1>Die Verwendung</h1>
<h2>Einlesen von Feeds</h2>
<p>&nbsp;</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Skript bearbeiten</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="js">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RSSFeed&nbsp;rss_read&nbsp;=&nbsp;<span class="js__operator">new</span>&nbsp;RSSFeed();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;rss_read.Load(path);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="js__string">&quot;Author:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;rss_read.Author);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="js__string">&quot;Author:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;rss_read.Language);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="js__string">&quot;Author:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;rss_read.Title);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="js__string">&quot;Author:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;rss_read.Updated);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="js__string">&quot;Author:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;rss_read.Version);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(<span class="js__string">&quot;Author:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&quot;</span>&nbsp;&#43;&nbsp;rss_read.WebMaster);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;foreach&nbsp;(RSSFeedArticle&nbsp;feed&nbsp;<span class="js__operator">in</span>&nbsp;rss_read.Articles)&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Console.WriteLine(feed.Title);</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<p>&nbsp;</p>
<p>Hierbei werden alle Eigenschaften der Artikel in der Konsole ausgegeben.</p>
<h2>Schreiben von Feeds</h2>
<p>F&uuml;r das erstellen eines Feeds gehen Sie so vor:</p>
<div class="scriptcode">
<div class="pluginEditHolder" pluginCommand="mceScriptCode">
<div class="title"><span>C#</span></div>
<div class="pluginLinkHolder"><span class="pluginEditHolderLink">Skript bearbeiten</span>|<span class="pluginRemoveHolderLink">Remove</span></div>
<span class="hidden">csharp</span>

<div class="preview">
<pre class="js">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;RSSFeed&nbsp;rss_write&nbsp;=&nbsp;<span class="js__operator">new</span>&nbsp;RSSFeed();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;rss_write.Author&nbsp;=&nbsp;<span class="js__string">&quot;Autor&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;rss_write.Description&nbsp;=&nbsp;<span class="js__string">&quot;Ein&nbsp;Newsfeed...&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;rss_write.Generator&nbsp;=&nbsp;<span class="js__string">&quot;Koopakiller.NewsFeed&nbsp;classes&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;rss_write.Title&nbsp;=&nbsp;<span class="js__string">&quot;Newsfeed&quot;</span>;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;rss_write.Language&nbsp;=&nbsp;CultureInfo.InvariantCulture;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;rss_write.Articles.Add(<span class="js__operator">new</span>&nbsp;RSSFeedArticle()&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__brace">{</span>&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Author&nbsp;=&nbsp;<span class="js__string">&quot;Autor&quot;</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Content&nbsp;=&nbsp;<span class="js__string">&quot;&lt;h1&gt;title&lt;/h1&gt;&lt;br/&gt;text&nbsp;&lt;em&gt;kursiv&lt;/em&gt;&quot;</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Title&nbsp;=&nbsp;<span class="js__string">&quot;Title&quot;</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;ArticleUrl&nbsp;=&nbsp;<span class="js__string">&quot;http://www.example.org&quot;</span>,&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="js__brace">}</span>);&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;path&nbsp;=&nbsp;Console.ReadLine();&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;rss_write.Save(path);</pre>
</div>
</div>
</div>
<div class="endscriptcode">&nbsp;</div>
<div class="endscriptcode">&nbsp;Sie erstellen ein neues Objekt der RSSFeed Klasse. Danach wei&szlig;en Sie ihr die ben&ouml;tigten Eigenschaften und Artikel zu. Des weiteren wird die Save()-Methode aufgerufen, wodurch der RSS Feed nun als Datei verf&uuml;gbar
 wird.</div>
<h1><span>Dateien im Projekt<br>
</span></h1>
<ul>
<li><em>Koopakiller.NewsFeed\...cs<br>
Dateien f&uuml;r das Lesen und schreiben von RSS und Atom Feeds.<br>
</em></li></ul>
