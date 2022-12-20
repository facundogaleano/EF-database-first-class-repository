using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

public partial class SevenPayTestEfContext : DbContext
{
    public SevenPayTestEfContext()
    {
    }

    public SevenPayTestEfContext(DbContextOptions<SevenPayTestEfContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccessToken> AccessTokens { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountBalance> AccountBalances { get; set; }

    public virtual DbSet<AccountSummary> AccountSummaries { get; set; }

    public virtual DbSet<Cable> Cables { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<DebtFree> DebtFrees { get; set; }

    public virtual DbSet<ExchangeCurrency> ExchangeCurrencies { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SpecialAccount> SpecialAccounts { get; set; }

    public virtual DbSet<Trading> Tradings { get; set; }

    public virtual DbSet<Transfer> Transfers { get; set; }

    public virtual DbSet<Treasury> Treasuries { get; set; }

    public virtual DbSet<Usdt> Usdts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=localhost\\MSSQLSERVER01;Database=SevenPayTestEF;Trusted_Connection=true;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<AccessToken>(entity =>
        {
            entity.HasKey(e => e.AccessTokenId).HasName("PK__AccessTo__8FB841A30A51E8E0");

            entity.Property(e => e.AccessToken1).HasColumnName("AccessToken");
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDateTime).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.AccessTokens)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AccessTok__UserI__3C69FB99");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Accounts__349DA5A662A6B454");

            entity.Property(e => e.BusinessName).HasMaxLength(100);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(60);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Observation).HasMaxLength(300);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SpecialAccountName).HasMaxLength(50);
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<AccountBalance>(entity =>
        {
            entity.HasKey(e => e.BalanceId).HasName("PK__AccountB__A760D5BE6173501D");

            entity.Property(e => e.Balance)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("balance");
        });

        modelBuilder.Entity<AccountSummary>(entity =>
        {
            entity.HasKey(e => e.SummaryId).HasName("PK__AccountS__DAB10E2FCBC8FFE3");

            entity.ToTable("AccountSummary");

            entity.Property(e => e.Balance).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Credit).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Debit).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Detail).HasMaxLength(1500);
            entity.Property(e => e.Movement).HasMaxLength(50);
            entity.Property(e => e.MovementId).HasColumnName("MovementID");
            entity.Property(e => e.Operation).HasMaxLength(50);
        });

        modelBuilder.Entity<Cable>(entity =>
        {
            entity.HasKey(e => e.CableId).HasName("PK__Cable__96C2A9DB14641B97");

            entity.ToTable("Cable");

            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Concept).HasMaxLength(1000);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DateOperation).HasColumnType("datetime");
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DestinationCommission).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.DestinationCommissionPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DestinationCurrencyBuyValue).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.OriginCommission).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.OriginCommissionPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.OriginCurrencySellValue).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.State).HasMaxLength(25);
            entity.Property(e => e.TotalCreditDestination).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TotalDebitOrigin).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Currency>(entity =>
        {
            entity.HasKey(e => e.CurrencyId).HasName("PK__Currenci__14470AF023D5A012");

            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.CurrencyName).HasMaxLength(100);
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Iso)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<DebtFree>(entity =>
        {
            entity.HasKey(e => e.DebtFreeId).HasName("PK__DebtFree__B20B33666175F19D");

            entity.ToTable("DebtFree");

            entity.Property(e => e.Amount).HasColumnType("decimal(15, 5)");
            entity.Property(e => e.Concept).HasMaxLength(1000);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(15);
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<ExchangeCurrency>(entity =>
        {
            entity.HasKey(e => e.ExchangeId).HasName("PK__Exchange__72E6008BCF1BF65C");

            entity.ToTable("ExchangeCurrency");

            entity.Property(e => e.BuyPrice).HasColumnType("decimal(15, 5)");
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.SellPrice).HasColumnType("decimal(15, 5)");
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Roles__8AFACE1ABE737051");

            entity.Property(e => e.RoleId).ValueGeneratedNever();
            entity.Property(e => e.Role1)
                .HasMaxLength(100)
                .HasColumnName("Role");
        });

        modelBuilder.Entity<SpecialAccount>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountType).HasMaxLength(50);
        });

        modelBuilder.Entity<Trading>(entity =>
        {
            entity.HasKey(e => e.TradingId).HasName("PK__Trading__9616D09F05B85B0F");

            entity.ToTable("Trading");

            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Concept).HasMaxLength(1000);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.ExchangeCurrencyValue).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.OperationType).HasMaxLength(20);
            entity.Property(e => e.State).HasMaxLength(20);
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Transfer>(entity =>
        {
            entity.HasKey(e => e.TransferId).HasName("PK__Transfer__95490091D225F730");

            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Concept).HasMaxLength(1000);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DateOperation).HasColumnType("datetime");
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DestinationCommission).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.DestinationCommissionPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DestinationCurrencyBuyValue).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.OriginCommission).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.OriginCommissionPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.OriginCurrencySellValue).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.State).HasMaxLength(25);
            entity.Property(e => e.TotalCreditDestination).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TotalDebitOrigin).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Treasury>(entity =>
        {
            entity.HasKey(e => e.TreasuryId).HasName("PK__Treasury__F1C917C3A46C6FEF");

            entity.ToTable("Treasury");

            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Concept).HasMaxLength(1000);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.State).HasMaxLength(15);
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<Usdt>(entity =>
        {
            entity.HasKey(e => e.UsdtId).HasName("PK__Usdt__1E37FA9128F1D86F");

            entity.ToTable("Usdt");

            entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Concept).HasMaxLength(1000);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DateOperation).HasColumnType("datetime");
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DestinationCommission).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.DestinationCommissionPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.DestinationCurrencyBuyValue).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.OperationType).HasMaxLength(10);
            entity.Property(e => e.OriginCommission).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.OriginCommissionPercentage).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.OriginCurrencySellValue).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.State).HasMaxLength(25);
            entity.Property(e => e.TotalCreditDestination).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.TotalDebitOrigin).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C47FA8DC8");

            entity.Property(e => e.ActivationKey).HasMaxLength(100);
            entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");
            entity.Property(e => e.DeletedDateTime).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.UpdatedDateTime).HasColumnType("datetime");

            entity.HasOne(d => d.Role).WithMany(p => p.Users)
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Users__RoleId__35BCFE0A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
