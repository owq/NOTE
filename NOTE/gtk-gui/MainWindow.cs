
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.UIManager UIManager;
	private global::Gtk.Action FileAction;
	private global::Gtk.Action HelpAction;
	private global::Gtk.Action deleteAction;
	private global::Gtk.Action saveAction;
	private global::Gtk.Action newAction;
	private global::Gtk.Action AboutAction;
	private global::Gtk.VBox vbox1;
	private global::Gtk.MenuBar menubar1;
	private global::Gtk.VBox vbox3;
	private global::Gtk.HBox hbox1;
	private global::Gtk.Toolbar toolbar1;
	private global::Gtk.ComboBoxEntry comboboxentry1;
	private global::Gtk.HPaned hpaned1;
	private global::Gtk.HPaned hpaned2;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TreeView treeviewTags;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.TreeView treeviewNotes;
	private global::Gtk.VBox vboxNote;
	private global::Gtk.Entry entryTitle;
	private global::Gtk.ScrolledWindow GtkScrolledWindow2;
	private global::Gtk.TextView textviewContent;
	private global::Gtk.Entry entryTags;
	private global::Gtk.HBox hbox2;
	private global::Gtk.Alignment alignment1;
	private global::Gtk.Button buttonSave;
	private global::Gtk.HButtonBox hbuttonbox1;
	private global::Gtk.Statusbar statusbar1;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.UIManager = new global::Gtk.UIManager ();
		global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
		this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
		this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
		w1.Add (this.FileAction, null);
		this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
		this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
		w1.Add (this.HelpAction, null);
		this.deleteAction = new global::Gtk.Action ("deleteAction", global::Mono.Unix.Catalog.GetString ("Delete Note"), null, "gtk-delete");
		this.deleteAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Delete Note");
		w1.Add (this.deleteAction, "Delete");
		this.saveAction = new global::Gtk.Action ("saveAction", global::Mono.Unix.Catalog.GetString ("Save Note"), global::Mono.Unix.Catalog.GetString ("Ctrl+S"), "gtk-save");
		this.saveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save Note");
		w1.Add (this.saveAction, "<Control>s");
		this.newAction = new global::Gtk.Action ("newAction", global::Mono.Unix.Catalog.GetString ("New Note"), null, "gtk-new");
		this.newAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("New Note");
		w1.Add (this.newAction, "<Control>n");
		this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
		this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
		w1.Add (this.AboutAction, null);
		this.UIManager.InsertActionGroup (w1, 0);
		this.AddAccelGroup (this.UIManager.AccelGroup);
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("NOTE - Open Thoughts Everytime");
		this.Icon = global::Stetic.IconLoader.LoadIcon (this, "gtk-about", global::Gtk.IconSize.Menu);
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		// Container child vbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString (@"<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='newAction' action='newAction'/><menuitem name='saveAction' action='saveAction'/><menuitem name='deleteAction' action='deleteAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
		this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
		this.menubar1.Name = "menubar1";
		this.vbox1.Add (this.menubar1);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		this.vbox3.BorderWidth = ((uint)(6));
		// Container child vbox3.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.UIManager.AddUiFromString ("<ui><toolbar name=\'toolbar1\'><toolitem name=\'newAction\' action=\'newAction\'/><tool" +
			"item name=\'saveAction\' action=\'saveAction\'/><toolitem name=\'deleteAction\' action" +
			"=\'deleteAction\'/></toolbar></ui>");
		this.toolbar1 = ((global::Gtk.Toolbar)(this.UIManager.GetWidget ("/toolbar1")));
		this.toolbar1.Name = "toolbar1";
		this.toolbar1.ShowArrow = false;
		this.hbox1.Add (this.toolbar1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.toolbar1]));
		w3.Position = 0;
		// Container child hbox1.Gtk.Box+BoxChild
		this.comboboxentry1 = global::Gtk.ComboBoxEntry.NewText ();
		this.comboboxentry1.Name = "comboboxentry1";
		this.hbox1.Add (this.comboboxentry1);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.comboboxentry1]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		this.vbox3.Add (this.hbox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbox1]));
		w5.Position = 0;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.hpaned1 = new global::Gtk.HPaned ();
		this.hpaned1.CanFocus = true;
		this.hpaned1.Name = "hpaned1";
		this.hpaned1.Position = 293;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.hpaned2 = new global::Gtk.HPaned ();
		this.hpaned2.CanFocus = true;
		this.hpaned2.Name = "hpaned2";
		this.hpaned2.Position = 144;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeviewTags = new global::Gtk.TreeView ();
		this.treeviewTags.WidthRequest = 50;
		this.treeviewTags.CanFocus = true;
		this.treeviewTags.Name = "treeviewTags";
		this.GtkScrolledWindow.Add (this.treeviewTags);
		this.hpaned2.Add (this.GtkScrolledWindow);
		global::Gtk.Paned.PanedChild w7 = ((global::Gtk.Paned.PanedChild)(this.hpaned2 [this.GtkScrolledWindow]));
		w7.Resize = false;
		// Container child hpaned2.Gtk.Paned+PanedChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.treeviewNotes = new global::Gtk.TreeView ();
		this.treeviewNotes.CanFocus = true;
		this.treeviewNotes.Name = "treeviewNotes";
		this.GtkScrolledWindow1.Add (this.treeviewNotes);
		this.hpaned2.Add (this.GtkScrolledWindow1);
		this.hpaned1.Add (this.hpaned2);
		global::Gtk.Paned.PanedChild w10 = ((global::Gtk.Paned.PanedChild)(this.hpaned1 [this.hpaned2]));
		w10.Resize = false;
		// Container child hpaned1.Gtk.Paned+PanedChild
		this.vboxNote = new global::Gtk.VBox ();
		this.vboxNote.Name = "vboxNote";
		this.vboxNote.Spacing = 6;
		// Container child vboxNote.Gtk.Box+BoxChild
		this.entryTitle = new global::Gtk.Entry ();
		this.entryTitle.CanDefault = true;
		this.entryTitle.CanFocus = true;
		this.entryTitle.Name = "entryTitle";
		this.entryTitle.IsEditable = true;
		this.entryTitle.ActivatesDefault = true;
		this.entryTitle.InvisibleChar = '●';
		this.vboxNote.Add (this.entryTitle);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vboxNote [this.entryTitle]));
		w11.Position = 0;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vboxNote.Gtk.Box+BoxChild
		this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
		this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
		this.textviewContent = new global::Gtk.TextView ();
		this.textviewContent.CanFocus = true;
		this.textviewContent.Name = "textviewContent";
		this.textviewContent.AcceptsTab = false;
		this.GtkScrolledWindow2.Add (this.textviewContent);
		this.vboxNote.Add (this.GtkScrolledWindow2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vboxNote [this.GtkScrolledWindow2]));
		w13.Position = 1;
		// Container child vboxNote.Gtk.Box+BoxChild
		this.entryTags = new global::Gtk.Entry ();
		this.entryTags.CanFocus = true;
		this.entryTags.Name = "entryTags";
		this.entryTags.IsEditable = true;
		this.entryTags.InvisibleChar = '●';
		this.vboxNote.Add (this.entryTags);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vboxNote [this.entryTags]));
		w14.Position = 2;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vboxNote.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
		this.alignment1.Name = "alignment1";
		this.hbox2.Add (this.alignment1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.alignment1]));
		w15.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.buttonSave = new global::Gtk.Button ();
		this.buttonSave.WidthRequest = 75;
		this.buttonSave.CanFocus = true;
		this.buttonSave.Name = "buttonSave";
		this.buttonSave.UseUnderline = true;
		// Container child buttonSave.Gtk.Container+ContainerChild
		global::Gtk.Alignment w16 = new global::Gtk.Alignment (0.5F, 0.5F, 0F, 0F);
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		global::Gtk.HBox w17 = new global::Gtk.HBox ();
		w17.Spacing = 2;
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Image w18 = new global::Gtk.Image ();
		w18.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-save", global::Gtk.IconSize.Menu);
		w17.Add (w18);
		// Container child GtkHBox.Gtk.Container+ContainerChild
		global::Gtk.Label w20 = new global::Gtk.Label ();
		w20.LabelProp = global::Mono.Unix.Catalog.GetString ("Save");
		w20.UseUnderline = true;
		w17.Add (w20);
		w16.Add (w17);
		this.buttonSave.Add (w16);
		this.hbox2.Add (this.buttonSave);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonSave]));
		w24.Position = 1;
		w24.Expand = false;
		w24.Fill = false;
		this.vboxNote.Add (this.hbox2);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vboxNote [this.hbox2]));
		w25.Position = 3;
		w25.Expand = false;
		w25.Fill = false;
		// Container child vboxNote.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox ();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.vboxNote.Add (this.hbuttonbox1);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vboxNote [this.hbuttonbox1]));
		w26.Position = 4;
		w26.Expand = false;
		w26.Fill = false;
		this.hpaned1.Add (this.vboxNote);
		this.vbox3.Add (this.hpaned1);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hpaned1]));
		w28.Position = 1;
		this.vbox1.Add (this.vbox3);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox3]));
		w29.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.statusbar1 = new global::Gtk.Statusbar ();
		this.statusbar1.Name = "statusbar1";
		this.statusbar1.Spacing = 6;
		this.vbox1.Add (this.statusbar1);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.statusbar1]));
		w30.Position = 2;
		w30.Expand = false;
		w30.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 752;
		this.DefaultHeight = 501;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.deleteAction.Activated += new global::System.EventHandler (this.OnDeleteNoteAction1Activated);
		this.saveAction.Activated += new global::System.EventHandler (this.OnSaveNoteAction2Activated);
		this.newAction.Activated += new global::System.EventHandler (this.OnNewActionActivated);
		this.treeviewTags.CursorChanged += new global::System.EventHandler (this.OnTreeviewTagsCursorChanged);
		this.treeviewNotes.CursorChanged += new global::System.EventHandler (this.OnTreeviewNotesCursorChanged);
		this.buttonSave.Released += new global::System.EventHandler (this.OnButtonSaveReleased);
	}
}
