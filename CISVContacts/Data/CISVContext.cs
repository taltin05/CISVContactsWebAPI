using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CISVContacts
{
    public partial class CISVContext : DbContext
    {
        public CISVContext()
        {
        }

        public CISVContext(DbContextOptions<CISVContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Audd> Audd { get; set; }
        public virtual DbSet<Audh> Audh { get; set; }
        public virtual DbSet<Chap> Chap { get; set; }
        public virtual DbSet<Clng> Clng { get; set; }
        public virtual DbSet<Cols> Cols { get; set; }
        public virtual DbSet<Cont> Cont { get; set; }
        public virtual DbSet<Coun> Coun { get; set; }
        public virtual DbSet<Fkey> Fkey { get; set; }
        public virtual DbSet<Lang> Lang { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<Ppar> Ppar { get; set; }
        public virtual DbSet<Prog> Prog { get; set; }
        public virtual DbSet<Rela> Rela { get; set; }
        public virtual DbSet<Rtyp> Rtyp { get; set; }
        public virtual DbSet<Sess> Sess { get; set; }
        public virtual DbSet<Syst> Syst { get; set; }
        public virtual DbSet<Tabl> Tabl { get; set; }
        public virtual DbSet<Usrs> Usrs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Audd>(entity =>
            {
                entity.ToTable("audd");

                entity.Property(e => e.AuddId).HasColumnName("audd_id");

                entity.Property(e => e.AudhId).HasColumnName("audh_id");

                entity.Property(e => e.ColumnName)
                    .HasColumnName("column_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewValue)
                    .HasColumnName("new_value")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OldValue)
                    .HasColumnName("old_value")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Audh>(entity =>
            {
                entity.ToTable("audh");

                entity.Property(e => e.AudhId).HasColumnName("audh_id");

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Operation)
                    .HasColumnName("operation")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.RowId).HasColumnName("row_id");

                entity.Property(e => e.SessId).HasColumnName("sess_id");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TransDate)
                    .HasColumnName("trans_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Chap>(entity =>
            {
                entity.ToTable("chap");

                entity.Property(e => e.ChapId).HasColumnName("chap_id");

                entity.Property(e => e.ChapterName)
                    .HasColumnName("chapter_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ChapterShort)
                    .HasColumnName("chapter_short")
                    .HasMaxLength(255);

                entity.Property(e => e.CounCode)
                    .HasColumnName("coun_code")
                    .HasMaxLength(3);

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");

                entity.Property(e => e.Url).HasColumnName("url");
            });

            modelBuilder.Entity<Clng>(entity =>
            {
                entity.ToTable("clng");

                entity.Property(e => e.ClngId).HasColumnName("clng_id");

                entity.Property(e => e.ContId).HasColumnName("cont_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.LangId).HasColumnName("lang_id");

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");
            });

            modelBuilder.Entity<Cols>(entity =>
            {
                entity.ToTable("cols");

                entity.Property(e => e.ColsId).HasColumnName("cols_id");

                entity.Property(e => e.AuditSort).HasColumnName("audit_sort");

                entity.Property(e => e.ColumnDescription)
                    .HasColumnName("column_description")
                    .HasMaxLength(50);

                entity.Property(e => e.ColumnName)
                    .HasColumnName("column_name")
                    .HasMaxLength(50);

                entity.Property(e => e.TablId).HasColumnName("tabl_id");
            });

            modelBuilder.Entity<Cont>(entity =>
            {
                entity.ToTable("cont");

                entity.Property(e => e.ContId).HasColumnName("cont_id");

                entity.Property(e => e.Addr1)
                    .HasColumnName("addr1")
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(20);

                entity.Property(e => e.Fundraising).HasColumnName("fundraising");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(1);

                entity.Property(e => e.HomePhone)
                    .HasColumnName("home_phone")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(30);

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobile_phone")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50);

                entity.Property(e => e.Zip)
                    .HasColumnName("zip")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Coun>(entity =>
            {
                entity.HasKey(e => e.CounCode);

                entity.ToTable("coun");

                entity.Property(e => e.CounCode)
                    .HasColumnName("coun_code")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");
            });

            modelBuilder.Entity<Fkey>(entity =>
            {
                entity.ToTable("fkey");

                entity.Property(e => e.FkeyId).HasColumnName("fkey_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DeleteTable)
                    .HasColumnName("delete_table")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LinkField)
                    .HasColumnName("link_field")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkTable)
                    .HasColumnName("link_table")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");
            });

            modelBuilder.Entity<Lang>(entity =>
            {
                entity.ToTable("lang");

                entity.Property(e => e.LangId).HasColumnName("lang_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(255);

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.ToTable("note");

                entity.Property(e => e.NoteId).HasColumnName("note_id");

                entity.Property(e => e.ContId).HasColumnName("cont_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Note1).HasColumnName("note");

                entity.Property(e => e.NoteDate)
                    .HasColumnName("note_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");

                entity.Property(e => e.UsrsId).HasColumnName("usrs_id");
            });

            modelBuilder.Entity<Ppar>(entity =>
            {
                entity.ToTable("ppar");

                entity.Property(e => e.PparId).HasColumnName("ppar_id");

                entity.Property(e => e.ContId).HasColumnName("cont_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DelegationChapId).HasColumnName("delegation_chap_id");

                entity.Property(e => e.HostChapId)
                    .HasColumnName("host_chap_id")
                    .HasMaxLength(255);

                entity.Property(e => e.HostCity)
                    .HasColumnName("host_city")
                    .HasMaxLength(25);

                entity.Property(e => e.HostCounCode)
                    .HasColumnName("host_coun_code")
                    .HasMaxLength(3);

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProgId).HasColumnName("prog_id");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<Prog>(entity =>
            {
                entity.ToTable("prog");

                entity.Property(e => e.ProgId).HasColumnName("prog_id");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasMaxLength(15);

                entity.Property(e => e.Caption)
                    .HasColumnName("caption")
                    .HasMaxLength(50);

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Program)
                    .HasColumnName("program")
                    .HasMaxLength(40);

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");

                entity.Property(e => e.SizeOfGroup).HasColumnName("size_of_group");
            });

            modelBuilder.Entity<Rela>(entity =>
            {
                entity.ToTable("rela");

                entity.Property(e => e.RelaId).HasColumnName("rela_id");

                entity.Property(e => e.ChildContId).HasColumnName("child_cont_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ParentContId).HasColumnName("parent_cont_id");

                entity.Property(e => e.RtypId).HasColumnName("rtyp_id");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");
            });

            modelBuilder.Entity<Rtyp>(entity =>
            {
                entity.ToTable("rtyp");

                entity.Property(e => e.RtypId).HasColumnName("rtyp_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.RelationshipType)
                    .HasColumnName("relationship_type")
                    .HasMaxLength(50);

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");
            });

            modelBuilder.Entity<Sess>(entity =>
            {
                entity.ToTable("sess");

                entity.Property(e => e.SessId).HasColumnName("sess_id");

                entity.Property(e => e.Browser)
                    .HasColumnName("browser")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpAddress)
                    .HasColumnName("ip_address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LoginDate)
                    .HasColumnName("login_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LogoutDate)
                    .HasColumnName("logout_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");

                entity.Property(e => e.UserAgent)
                    .HasColumnName("user_agent")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UsrsId).HasColumnName("usrs_id");
            });

            modelBuilder.Entity<Syst>(entity =>
            {
                entity.ToTable("syst");

                entity.Property(e => e.SystId).HasColumnName("syst_id");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Homepage)
                    .HasColumnName("homepage")
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PasswordMinlength).HasColumnName("password_minlength");

                entity.Property(e => e.PasswordNumeric).HasColumnName("password_numeric");

                entity.Property(e => e.PasswordSpecial).HasColumnName("password_special");

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");
            });

            modelBuilder.Entity<Tabl>(entity =>
            {
                entity.ToTable("tabl");

                entity.Property(e => e.TablId).HasColumnName("tabl_id");

                entity.Property(e => e.TableDescription)
                    .HasColumnName("table_description")
                    .HasMaxLength(50);

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Usrs>(entity =>
            {
                entity.ToTable("usrs");

                entity.Property(e => e.UsrsId).HasColumnName("usrs_id");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.Admin).HasColumnName("admin");

                entity.Property(e => e.CreateDatetime)
                    .HasColumnName("create_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDatetime)
                    .HasColumnName("modify_datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassHash)
                    .HasColumnName("pass_hash")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SessIdCreate).HasColumnName("sess_id_create");

                entity.Property(e => e.SessIdModify).HasColumnName("sess_id_modify");
            });
        }
    }
}
