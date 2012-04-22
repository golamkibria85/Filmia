
/*
	This code was generated by SQL Compact Code Generator version 1.2.0.3

	SQL Compact Code Generator was written by Christian Resma Helle (http://sqlcecodegen.codeplex.com)
	and is under the GNU General Public License version 2 (GPLv2)

	Generated: 02/21/2012 01:40:52
*/


namespace GrandAStudio.Filmia
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.ComponentModel;
    using Microsoft.Phone.Data.Linq;
    using System.Collections.Generic;
    using System;

	/// <summary>
	/// Represents the Categories table in the database
	/// </summary>
	[Table]
	public partial class Categories : INotifyPropertyChanged, INotifyPropertyChanging
	{
		private System.Int64? _IID;
		private System.String _Name;
		private System.String _UnlockCode;
		private System.Byte? _IsUnlocked;
		private System.Byte? _IsCompleted;
		private System.Byte? _IsDeleted;

		[Column(IsVersion = true)]
		private Binary version;
		public event PropertyChangedEventHandler PropertyChanged;
		public event PropertyChangingEventHandler PropertyChanging;

		/// <summary>
		/// Gets or sets the value of IID
		/// </summary>
		[Column(Name = "IID", IsPrimaryKey = true, IsDbGenerated = true)]
		public System.Int64? IID
		{
			get { return _IID; }
			set
			{
				if (_IID != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IID"));
					_IID = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IID"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of Name
		/// </summary>
		[Column(Name = "Name")]
		public System.String Name
		{
			get { return _Name; }
			set
			{
				if (_Name != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("Name"));
					_Name = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of UnlockCode
		/// </summary>
		[Column(Name = "UnlockCode")]
		public System.String UnlockCode
		{
			get { return _UnlockCode; }
			set
			{
				if (_UnlockCode != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("UnlockCode"));
					_UnlockCode = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("UnlockCode"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of IsUnlocked
		/// </summary>
		[Column(Name = "IsUnlocked")]
		public System.Byte? IsUnlocked
		{
			get { return _IsUnlocked; }
			set
			{
				if (_IsUnlocked != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IsUnlocked"));
					_IsUnlocked = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsUnlocked"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of IsCompleted
		/// </summary>
		[Column(Name = "IsCompleted")]
		public System.Byte? IsCompleted
		{
			get { return _IsCompleted; }
			set
			{
				if (_IsCompleted != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IsCompleted"));
					_IsCompleted = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsCompleted"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of IsDeleted
		/// </summary>
		[Column(Name = "IsDeleted")]
		public System.Byte? IsDeleted
		{
			get { return _IsDeleted; }
			set
			{
				if (_IsDeleted != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IsDeleted"));
					_IsDeleted = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsDeleted"));
				}
			}
		}

	}

	/// <summary>
	/// Represents the Questions table in the database
	/// </summary>
	[Table]
	public partial class Questions : INotifyPropertyChanged, INotifyPropertyChanging
	{
		private System.Int64? _CategoryID;
		private System.String _Question;
		private System.String _Answer1;
		private System.String _Answer2;
		private System.String _Answer3;
		private System.String _Answer4;
		private System.Byte? _CorrectAns;
		private System.Byte? _IsAnswered;
		private System.Byte? _IsAsked;
		private System.Byte? _IsDeleted;
		private System.Int64? _IID;

	    [Column(IsVersion = true)]
		private Binary version;
		public event PropertyChangedEventHandler PropertyChanged;
		public event PropertyChangingEventHandler PropertyChanging;

		/// <summary>
		/// Gets or sets the value of CategoryID
		/// </summary>
		[Column(Name = "CategoryID")]
		public System.Int64? CategoryID
		{
			get { return _CategoryID; }
			set
			{
				if (_CategoryID != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("CategoryID"));
					_CategoryID = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("CategoryID"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of Question
		/// </summary>
		[Column(Name = "Question")]
		public System.String Question
		{
			get { return _Question; }
			set
			{
				if (_Question != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("Question"));
					_Question = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Question"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of Answer1
		/// </summary>
		[Column(Name = "Answer1")]
		public System.String Answer1
		{
			get { return _Answer1; }
			set
			{
				if (_Answer1 != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("Answer1"));
					_Answer1 = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Answer1"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of Answer2
		/// </summary>
		[Column(Name = "Answer2")]
		public System.String Answer2
		{
			get { return _Answer2; }
			set
			{
				if (_Answer2 != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("Answer2"));
					_Answer2 = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Answer2"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of Answer3
		/// </summary>
		[Column(Name = "Answer3")]
		public System.String Answer3
		{
			get { return _Answer3; }
			set
			{
				if (_Answer3 != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("Answer3"));
					_Answer3 = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Answer3"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of Answer4
		/// </summary>
		[Column(Name = "Answer4")]
		public System.String Answer4
		{
			get { return _Answer4; }
			set
			{
				if (_Answer4 != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("Answer4"));
					_Answer4 = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Answer4"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of CorrectAns
		/// </summary>
		[Column(Name = "CorrectAns")]
		public System.Byte? CorrectAns
		{
			get { return _CorrectAns; }
			set
			{
				if (_CorrectAns != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("CorrectAns"));
					_CorrectAns = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("CorrectAns"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of IsAnswered
		/// </summary>
		[Column(Name = "IsAnswered")]
		public System.Byte? IsAnswered
		{
			get { return _IsAnswered; }
			set
			{
				if (_IsAnswered != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IsAnswered"));
					_IsAnswered = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsAnswered"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of IsAsked
		/// </summary>
		[Column(Name = "IsAsked")]
		public System.Byte? IsAsked
		{
			get { return _IsAsked; }
			set
			{
				if (_IsAsked != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IsAsked"));
					_IsAsked = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsAsked"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of IsDeleted
		/// </summary>
		[Column(Name = "IsDeleted")]
		public System.Byte? IsDeleted
		{
			get { return _IsDeleted; }
			set
			{
				if (_IsDeleted != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IsDeleted"));
					_IsDeleted = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IsDeleted"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of IID
		/// </summary>
		[Column(Name = "IID", IsPrimaryKey = true, IsDbGenerated = true)]
		public System.Int64? IID
		{
			get { return _IID; }
			set
			{
				if (_IID != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IID"));
					_IID = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IID"));
				}
			}
		}

        List<Answer> answers = new List<Answer>();

        public List<Answer> Answers {
                get
                {
                    answers.Add(new Answer(Answer1 ,3));
                    answers.Add(new Answer(Answer2, -2));
                    answers.Add(new Answer(Answer3, -2));
                    answers.Add(new Answer(Answer4, -2));

                    return ShuffleList<Answer>(answers);

            
                }
           
            }
        private List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }

	}
    public class Answer 
    {
        public Answer(string ans, int isCorrect)
        {
            this.answer = ans;
            this.IsCorrect = isCorrect;
            isClicked = 0;
        }
        public string  answer { get; set; }
        public int  IsCorrect { get; set; }
        public int isClicked { get; set; }

    }

	/// <summary>
	/// Represents the Score table in the database
	/// </summary>
	[Table]
	public partial class Score : INotifyPropertyChanged, INotifyPropertyChanging
	{
		private System.Int64? _IID;
		private System.Int64? _Total;

		[Column(IsVersion = true)]
		private Binary version;
		public event PropertyChangedEventHandler PropertyChanged;
		public event PropertyChangingEventHandler PropertyChanging;

		/// <summary>
		/// Gets or sets the value of IID
		/// </summary>
		[Column(Name = "IID", IsPrimaryKey = true)]
		public System.Int64? IID
		{
			get { return _IID; }
			set
			{
				if (_IID != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("IID"));
					_IID = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("IID"));
				}
			}
		}

		/// <summary>
		/// Gets or sets the value of Total
		/// </summary>
		[Column(Name = "Total")]
		public System.Int64? Total
		{
			get { return _Total; }
			set
			{
				if (_Total != value)
				{
				if (PropertyChanging != null)
						PropertyChanging.Invoke(this, new PropertyChangingEventArgs("Total"));
					_Total = value;
					if (PropertyChanged != null)
						PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Total"));
				}
			}
		}

        private System.Int64? _TotalGames;
        /// <summary>
        /// Gets or sets the value of Total
        /// </summary>
        [Column(Name = "TotalGames")]
        public System.Int64? TotalGames
        {
            get { return _TotalGames; }
            set
            {
                if (_TotalGames != value)
                {
                    if (PropertyChanging != null)
                        PropertyChanging.Invoke(this, new PropertyChangingEventArgs("TotalGames"));
                    _TotalGames = value;
                    if (PropertyChanged != null)
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TotalGames"));
                }
            }
        }
        private System.Int64? _TotalQuestions;
        /// <summary>
        /// Gets or sets the value of Total
        /// </summary>
        [Column(Name = "TotalQuestions")]
        public System.Int64? TotalQuestions
        {
            get { return _TotalQuestions; }
            set
            {
                if (_TotalQuestions != value)
                {
                    if (PropertyChanging != null)
                        PropertyChanging.Invoke(this, new PropertyChangingEventArgs("TotalQuestions"));
                    _TotalQuestions = value;
                    if (PropertyChanged != null)
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TotalQuestions"));
                }
            }
        }

        private System.Int64? _TotalRightAnswers;
        /// <summary>
        /// Gets or sets the value of Total
        /// </summary>
        [Column(Name = "TotalRightAnswers")]
        public System.Int64? TotalRightAnswers
        {
            get { return _TotalRightAnswers; }
            set
            {
                if (_TotalRightAnswers != value)
                {
                    if (PropertyChanging != null)
                        PropertyChanging.Invoke(this, new PropertyChangingEventArgs("TotalRightAnswers"));
                    _TotalRightAnswers = value;
                    if (PropertyChanged != null)
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TotalRightAnswers"));
                }
            }
        }
        private System.Int64? _TotlaWrongAnswers;
        /// <summary>
        /// Gets or sets the value of Total
        /// </summary>
        [Column(Name = "TotlaWrongAnswers")]
        public System.Int64? TotlaWrongAnswers
        {
            get { return _TotlaWrongAnswers; }
            set
            {
                if (_TotlaWrongAnswers != value)
                {
                    if (PropertyChanging != null)
                        PropertyChanging.Invoke(this, new PropertyChangingEventArgs("TotlaWrongAnswers"));
                    _TotlaWrongAnswers = value;
                    if (PropertyChanged != null)
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TotlaWrongAnswers"));
                }
            }
        }
        private System.Int64? _TotalPasses;
        /// <summary>
        /// Gets or sets the value of Total
        /// </summary>
        [Column(Name = "TotalPasses")]
        public System.Int64? TotalPasses
        {
            get { return _TotalPasses; }
            set
            {
                if (_TotalPasses != value)
                {
                    if (PropertyChanging != null)
                        PropertyChanging.Invoke(this, new PropertyChangingEventArgs("TotalPasses"));
                    _TotalPasses = value;
                    if (PropertyChanged != null)
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("TotalPasses"));
                }
            }
        }
        private System.String _AvailPasses;
        /// <summary>
        /// Gets or sets the value of Total
        /// </summary>
        [Column(Name = "AvailPasses")]
        public System.String AvailPasses
        {
            get { return _AvailPasses; }
            set
            {
                if (_AvailPasses != value)
                {
                    if (PropertyChanging != null)
                        PropertyChanging.Invoke(this, new PropertyChangingEventArgs("AvailPasses"));
                    _AvailPasses = value;
                    if (PropertyChanged != null)
                        PropertyChanged.Invoke(this, new PropertyChangedEventArgs("AvailPasses"));
                }
            }
        }


	}

}


namespace GrandAStudio.Filmia
{
	using System.Data.Linq;
    using Microsoft.Phone.Data.Linq;
    using System.IO.IsolatedStorage;
    using System.IO;
    using System.Windows;
    using System;

	/// <summary>
	/// Represents the Moviadb1 data context
	/// </summary>
	public partial class Moviadb1DataContext : DataContext
	{
		/// <summary>
		/// Global Connection String
		/// </summary>
		public static string ConnectionString = "Data Source=isostore:/Moviadb1.sdf";
        //public static string ConnectionString = "Data Source=appdata:/Moviadb1.sdf";
		/// <summary>
		/// Creates an instance of the Moviadb1 data context
		/// </summary>
		public Moviadb1DataContext () : this(ConnectionString)
		{
		}

		/// <summary>
		/// Creates an instance of the Moviadb1 data context
		/// </summary>
		/// <param name="connectionString">connection string to be used for this instance</param>
		public Moviadb1DataContext (string connectionString) : base(connectionString)
		{
            IsolatedStorageFile iso = IsolatedStorageFile.GetUserStoreForApplication();

            if (!iso.FileExists("Moviadb1.sdf"))
            {
                MoveReferenceDatabase();
            }

			if (!DatabaseExists())
				CreateDatabase();
		}

        public static void MoveReferenceDatabase()
        {
            // Obtain the virtual store for the application.
            IsolatedStorageFile iso = IsolatedStorageFile.GetUserStoreForApplication();

            // Create a stream for the file in the installation folder.
            using (Stream input = Application.GetResourceStream(new Uri("Moviadb1.sdf", UriKind.Relative)).Stream)
            {
                // Create a stream for the new file in isolated storage.

                using (IsolatedStorageFileStream output = iso.CreateFile("Moviadb1.sdf"))
                {
                    // Initialize the buffer.
                    byte[] readBuffer = new byte[4096];
                    int bytesRead = -1;

                    // Copy the file from the installation folder to isolated storage. 
                    while ((bytesRead = input.Read(readBuffer, 0, readBuffer.Length)) > 0)
                    {
                        output.Write(readBuffer, 0, bytesRead);
                    }
                }
            }
        }

		/// <summary>
		/// Represents the Categories table
		/// </summary>
		public Table<Categories> Categories;

		/// <summary>
		/// Represents the Questions table
		/// </summary>
		public Table<Questions> Questions;

		/// <summary>
		/// Represents the Score table
		/// </summary>
		public Table<Score> Score;
	}
}
