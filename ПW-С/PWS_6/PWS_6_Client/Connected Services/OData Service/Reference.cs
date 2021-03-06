﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 22.02.2020 14:01:58
namespace Reference
{
    
    /// <summary>
    /// There are no comments for WSCAVEntities1 in the schema.
    /// </summary>
    public partial class WSCAVEntities1 : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new WSCAVEntities1 object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public WSCAVEntities1(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "PWS_6", "Reference");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("Reference", global::System.StringComparison.Ordinal))
            {
                return string.Concat("PWS_6.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Note> Notes
        {
            get
            {
                if ((this._Notes == null))
                {
                    this._Notes = base.CreateQuery<Note>("Notes");
                }
                return this._Notes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Note> _Notes;
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Student> Students
        {
            get
            {
                if ((this._Students == null))
                {
                    this._Students = base.CreateQuery<Student>("Students");
                }
                return this._Students;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Student> _Students;
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToNotes(Note note)
        {
            base.AddObject("Notes", note);
        }
        /// <summary>
        /// There are no comments for Students in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = "<edmx:Edmx Version=\"1.0\" xmlns:edmx=\"http://schemas.microsoft.com/ado/2007/06/edm" +
                "x\"><edmx:DataServices m:DataServiceVersion=\"1.0\" m:MaxDataServiceVersion=\"3.0\" x" +
                "mlns:m=\"http://schemas.microsoft.com/ado/2007/08/dataservices/metadata\"><Schema " +
                "Namespace=\"PWS_6\" xmlns=\"http://schemas.microsoft.com/ado/2009/11/edm\"><EntityTy" +
                "pe Name=\"Note\"><Key><PropertyRef Name=\"Id\" /></Key><Property Name=\"Id\" Type=\"Edm" +
                ".Int32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"http://sc" +
                "hemas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"Subj\" Type=\"Ed" +
                "m.String\" MaxLength=\"Max\" FixedLength=\"false\" Unicode=\"true\" /><Property Name=\"N" +
                "ote1\" Type=\"Edm.Int32\" /><Property Name=\"StudentId\" Type=\"Edm.Int32\" Nullable=\"f" +
                "alse\" /><NavigationProperty Name=\"Student\" Relationship=\"PWS_6.Student_Notes\" To" +
                "Role=\"Student_Notes_Source\" FromRole=\"Student_Notes_Target\" /></EntityType><Enti" +
                "tyType Name=\"Student\"><Key><PropertyRef Name=\"Id\" /></Key><Property Name=\"Id\" Ty" +
                "pe=\"Edm.Int32\" Nullable=\"false\" p6:StoreGeneratedPattern=\"Identity\" xmlns:p6=\"ht" +
                "tp://schemas.microsoft.com/ado/2009/02/edm/annotation\" /><Property Name=\"Name\" T" +
                "ype=\"Edm.String\" MaxLength=\"Max\" FixedLength=\"false\" Unicode=\"true\" /><Navigatio" +
                "nProperty Name=\"Notes\" Relationship=\"PWS_6.Student_Notes\" ToRole=\"Student_Notes_" +
                "Target\" FromRole=\"Student_Notes_Source\" /></EntityType><Association Name=\"Studen" +
                "t_Notes\"><End Type=\"PWS_6.Student\" Role=\"Student_Notes_Source\" Multiplicity=\"1\">" +
                "<OnDelete Action=\"Cascade\" /></End><End Type=\"PWS_6.Note\" Role=\"Student_Notes_Ta" +
                "rget\" Multiplicity=\"*\" /><ReferentialConstraint><Principal Role=\"Student_Notes_S" +
                "ource\"><PropertyRef Name=\"Id\" /></Principal><Dependent Role=\"Student_Notes_Targe" +
                "t\"><PropertyRef Name=\"StudentId\" /></Dependent></ReferentialConstraint></Associa" +
                "tion><EntityContainer Name=\"WSCAVEntities1\" m:IsDefaultEntityContainer=\"true\"><E" +
                "ntitySet Name=\"Notes\" EntityType=\"PWS_6.Note\" /><EntitySet Name=\"Students\" Entit" +
                "yType=\"PWS_6.Student\" /><AssociationSet Name=\"Student_Notes\" Association=\"PWS_6." +
                "Student_Notes\"><End Role=\"Student_Notes_Target\" EntitySet=\"Notes\" /><End Role=\"S" +
                "tudent_Notes_Source\" EntitySet=\"Students\" /></AssociationSet></EntityContainer><" +
                "/Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for PWS_6.Note in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Notes")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Note : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Note object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="studentId">Initial value of StudentId.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Note CreateNote(int ID, int studentId)
        {
            Note note = new Note();
            note.Id = ID;
            note.StudentId = studentId;
            return note;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Subj in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Subj
        {
            get
            {
                return this._Subj;
            }
            set
            {
                this.OnSubjChanging(value);
                this._Subj = value;
                this.OnSubjChanged();
                this.OnPropertyChanged("Subj");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Subj;
        partial void OnSubjChanging(string value);
        partial void OnSubjChanged();
        /// <summary>
        /// There are no comments for Property Note1 in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<int> Note1
        {
            get
            {
                return this._Note1;
            }
            set
            {
                this.OnNote1Changing(value);
                this._Note1 = value;
                this.OnNote1Changed();
                this.OnPropertyChanged("Note1");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<int> _Note1;
        partial void OnNote1Changing(global::System.Nullable<int> value);
        partial void OnNote1Changed();
        /// <summary>
        /// There are no comments for Property StudentId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int StudentId
        {
            get
            {
                return this._StudentId;
            }
            set
            {
                this.OnStudentIdChanging(value);
                this._StudentId = value;
                this.OnStudentIdChanged();
                this.OnPropertyChanged("StudentId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _StudentId;
        partial void OnStudentIdChanging(int value);
        partial void OnStudentIdChanged();
        /// <summary>
        /// There are no comments for Student in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Student Student
        {
            get
            {
                return this._Student;
            }
            set
            {
                this._Student = value;
                this.OnPropertyChanged("Student");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Student _Student;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for PWS_6.Student in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Students")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Student : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Student object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Student CreateStudent(int ID)
        {
            Student student = new Student();
            student.Id = ID;
            return student;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Notes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Note> Notes
        {
            get
            {
                return this._Notes;
            }
            set
            {
                this._Notes = value;
                this.OnPropertyChanged("Notes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Note> _Notes = new global::System.Data.Services.Client.DataServiceCollection<Note>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
