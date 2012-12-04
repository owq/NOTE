
// This file has been generated by the GUI designer. Do not modify.
namespace NOTE
{
	public partial class NoteEditor
	{
		private global::Gtk.VBox vbox4;
		private global::Gtk.Entry entryTitle;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TextView textviewContent;
		private global::Gtk.Entry entryTags;
		private global::Gtk.HBox hbox1;
		private global::Gtk.Alignment alignment1;
		private global::Gtk.Button buttonSave;
		private global::Gtk.HButtonBox hbuttonbox1;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget NOTE.NoteEditor
			global::Stetic.BinContainer.Attach (this);
			this.Name = "NOTE.NoteEditor";
			// Container child NOTE.NoteEditor.Gtk.Container+ContainerChild
			this.vbox4 = new global::Gtk.VBox ();
			this.vbox4.Name = "vbox4";
			this.vbox4.Spacing = 6;
			// Container child vbox4.Gtk.Box+BoxChild
			this.entryTitle = new global::Gtk.Entry ();
			this.entryTitle.CanFocus = true;
			this.entryTitle.Name = "entryTitle";
			this.entryTitle.IsEditable = true;
			this.entryTitle.InvisibleChar = '●';
			this.vbox4.Add (this.entryTitle);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.entryTitle]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textviewContent = new global::Gtk.TextView ();
			this.textviewContent.CanFocus = true;
			this.textviewContent.Name = "textviewContent";
			this.textviewContent.AcceptsTab = false;
			this.GtkScrolledWindow.Add (this.textviewContent);
			this.vbox4.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.GtkScrolledWindow]));
			w3.Position = 1;
			// Container child vbox4.Gtk.Box+BoxChild
			this.entryTags = new global::Gtk.Entry ();
			this.entryTags.CanFocus = true;
			this.entryTags.Name = "entryTags";
			this.entryTags.IsEditable = true;
			this.entryTags.InvisibleChar = '●';
			this.vbox4.Add (this.entryTags);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.entryTags]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.alignment1 = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.alignment1.Name = "alignment1";
			this.hbox1.Add (this.alignment1);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.alignment1]));
			w5.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonSave = new global::Gtk.Button ();
			this.buttonSave.WidthRequest = 75;
			this.buttonSave.CanFocus = true;
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.UseUnderline = true;
			this.buttonSave.Label = global::Mono.Unix.Catalog.GetString ("Save");
			this.hbox1.Add (this.buttonSave);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonSave]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox4.Add (this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbox1]));
			w7.Position = 3;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox4.Gtk.Box+BoxChild
			this.hbuttonbox1 = new global::Gtk.HButtonBox ();
			this.hbuttonbox1.Name = "hbuttonbox1";
			this.vbox4.Add (this.hbuttonbox1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.hbuttonbox1]));
			w8.Position = 4;
			w8.Expand = false;
			w8.Fill = false;
			this.Add (this.vbox4);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
			this.entryTitle.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnEntryTitleKeyPressEvent);
			this.textviewContent.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnTextviewContentKeyPressEvent);
			this.buttonSave.Released += new global::System.EventHandler (this.OnSave);
			this.buttonSave.KeyPressEvent += new global::Gtk.KeyPressEventHandler (this.OnButton1KeyPressEvent);
			this.buttonSave.Activated += new global::System.EventHandler (this.OnSave);
		}
	}
}
