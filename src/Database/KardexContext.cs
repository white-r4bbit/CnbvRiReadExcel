using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExcelReader.Database;

public partial class KardexContext : DbContext
{
    public KardexContext()
    {
    }

    public KardexContext(DbContextOptions<KardexContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividad> Actividads { get; set; }

    public virtual DbSet<ActivityType> ActivityTypes { get; set; }

    public virtual DbSet<AlternativeDepartment> AlternativeDepartments { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<AreaRiskMetadatum> AreaRiskMetadata { get; set; }

    public virtual DbSet<AreaSpeciality> AreaSpecialities { get; set; }

    public virtual DbSet<AreaType> AreaTypes { get; set; }

    public virtual DbSet<Binnacle> Binnacles { get; set; }

    public virtual DbSet<BpmRole1> BpmRoles { get; set; }

    public virtual DbSet<Bpmrole> Bpmroles { get; set; }

    public virtual DbSet<BusinessGroup> BusinessGroups { get; set; }

    public virtual DbSet<BusinessProcess> BusinessProcesses { get; set; }

    public virtual DbSet<BusinessProcessRole> BusinessProcessRoles { get; set; }

    public virtual DbSet<Capture> Captures { get; set; }

    public virtual DbSet<CaptureManualInfo> CaptureManualInfos { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CeferMetadatum> CeferMetadata { get; set; }

    public virtual DbSet<ComentariosReporteInstitucional> ComentariosReporteInstitucionals { get; set; }

    public virtual DbSet<Configuracion> Configuracions { get; set; }

    public virtual DbSet<DataType> DataTypes { get; set; }

    public virtual DbSet<Deadline> Deadlines { get; set; }

    public virtual DbSet<DepartmentParticipant> DepartmentParticipants { get; set; }

    public virtual DbSet<DynamicRisksConfiguration> DynamicRisksConfigurations { get; set; }

    public virtual DbSet<Entity> Entities { get; set; }

    public virtual DbSet<EntityProcessRole> EntityProcessRoles { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Event1> Events1 { get; set; }

    public virtual DbSet<Event2> Events2 { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<ExpertAdjustmentLog> ExpertAdjustmentLogs { get; set; }

    public virtual DbSet<ExportedFile> ExportedFiles { get; set; }

    public virtual DbSet<ExternalSource> ExternalSources { get; set; }

    public virtual DbSet<IndexScript> IndexScripts { get; set; }

    public virtual DbSet<Indicator> Indicators { get; set; }

    public virtual DbSet<InherentRisk> InherentRisks { get; set; }

    public virtual DbSet<InherentRiskMetadatum> InherentRiskMetadata { get; set; }

    public virtual DbSet<InstitutionCategoriesResponsible> InstitutionCategoriesResponsibles { get; set; }

    public virtual DbSet<LastPeriod> LastPeriods { get; set; }

    public virtual DbSet<ManagedFile> ManagedFiles { get; set; }

    public virtual DbSet<ManualInfoMetadatum> ManualInfoMetadata { get; set; }

    public virtual DbSet<Matrix> Matrices { get; set; }

    public virtual DbSet<MatrixFile> MatrixFiles { get; set; }

    public virtual DbSet<MatrixParticipant> MatrixParticipants { get; set; }

    public virtual DbSet<MatrixSetupInstance> MatrixSetupInstances { get; set; }

    public virtual DbSet<MatrixType> MatrixTypes { get; set; }

    public virtual DbSet<Mitigating> Mitigatings { get; set; }

    public virtual DbSet<MitigatingMetadatum> MitigatingMetadata { get; set; }

    public virtual DbSet<MitigatingRate> MitigatingRates { get; set; }

    public virtual DbSet<MultipleOption> MultipleOptions { get; set; }

    public virtual DbSet<Notch> Notches { get; set; }

    public virtual DbSet<PageAccess> PageAccesses { get; set; }

    public virtual DbSet<Period> Periods { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<ProcessInstance> ProcessInstances { get; set; }

    public virtual DbSet<RateStatus> RateStatuses { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportCapture> ReportCaptures { get; set; }

    public virtual DbSet<ReportCategory> ReportCategories { get; set; }

    public virtual DbSet<ReportUpdate> ReportUpdates { get; set; }

    public virtual DbSet<RiskIndicatorMetadatum> RiskIndicatorMetadata { get; set; }

    public virtual DbSet<RiskProperty> RiskProperties { get; set; }

    public virtual DbSet<RiskPropertyMetadatum> RiskPropertyMetadata { get; set; }

    public virtual DbSet<RiskRate> RiskRates { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Sector> Sectors { get; set; }

    public virtual DbSet<SectorVersion> SectorVersions { get; set; }

    public virtual DbSet<SectorVersionCategory> SectorVersionCategories { get; set; }

    public virtual DbSet<Speciality> Specialities { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<StoredFile> StoredFiles { get; set; }

    public virtual DbSet<Subsistema> Subsistemas { get; set; }

    public virtual DbSet<Subsystem> Subsystems { get; set; }

    public virtual DbSet<SystemicInstitution> SystemicInstitutions { get; set; }

    public virtual DbSet<TipoEvento> TipoEventos { get; set; }

    public virtual DbSet<Trace> Traces { get; set; }

    public virtual DbSet<UnmanagedSector> UnmanagedSectors { get; set; }

    public virtual DbSet<UnmanagedSectorFile> UnmanagedSectorFiles { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VwMatrix> VwMatrices { get; set; }

    public virtual DbSet<VwMatrixFile> VwMatrixFiles { get; set; }

    public virtual DbSet<VwMatrixMitigatingRate> VwMatrixMitigatingRates { get; set; }

    public virtual DbSet<VwMatrixParticipant> VwMatrixParticipants { get; set; }

    public virtual DbSet<VwMatrixProcessInstance> VwMatrixProcessInstances { get; set; }

    public virtual DbSet<VwMatrixRiskConfiguration> VwMatrixRiskConfigurations { get; set; }

    public virtual DbSet<VwMatrixRiskRate> VwMatrixRiskRates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SR11VIBD03\\SQLPRO3CS;User=idgenkardex;Password=k6i%547>=kfk3;Database=Kardex;Integrated Security=false;Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividad>(entity =>
        {
            entity.ToTable("Actividad", "Adm");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Subsistema).WithMany(p => p.Actividads)
                .HasForeignKey(d => d.SubsistemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Actividad_ToSubsistema");
        });

        modelBuilder.Entity<ActivityType>(entity =>
        {
            entity.ToTable("ActivityType", "Tracing");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AlternativeDepartment>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("AlternativeDepartment", "Catalog");

            entity.Property(e => e.UserId)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.ToTable("Area", "Catalog");

            entity.HasIndex(e => e.PesKey, "uc_PesKey").IsUnique();

            entity.Property(e => e.PesKey)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.Type).WithMany(p => p.Areas)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Area_AreaType");
        });

        modelBuilder.Entity<AreaRiskMetadatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AreaRiskMetadata", "Cefer");

            entity.HasOne(d => d.Area).WithMany()
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaRiskMetadata_Area");

            entity.HasOne(d => d.InherentRisk).WithMany()
                .HasForeignKey(d => d.InherentRiskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AreaRiskMetadata_InherentRisk");
        });

        modelBuilder.Entity<AreaSpeciality>(entity =>
        {
            entity.HasKey(e => new { e.AreaId, e.SpecialityId }).HasName("PKAreaSpecialities");

            entity.ToTable("AreaSpecialities", "InstitutionalReport");

            entity.HasOne(d => d.Area).WithMany(p => p.AreaSpecialities)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKAreaSpecialitiesArea");

            entity.HasOne(d => d.Speciality).WithMany(p => p.AreaSpecialities)
                .HasForeignKey(d => d.SpecialityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKAreaSpecialitiesSpeciality");
        });

        modelBuilder.Entity<AreaType>(entity =>
        {
            entity.ToTable("AreaType", "Catalog");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Binnacle>(entity =>
        {
            entity.ToTable("Binnacle", "Cefer");

            entity.Property(e => e.Date).HasColumnType("datetime");

            entity.HasOne(d => d.Event).WithMany(p => p.Binnacles)
                .HasForeignKey(d => d.EventId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Binnacle_Event");

            entity.HasOne(d => d.Matrix).WithMany(p => p.Binnacles)
                .HasForeignKey(d => d.MatrixId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Binnacle_Matrix");

            entity.HasOne(d => d.User).WithMany(p => p.Binnacles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Binnacle_User");
        });

        modelBuilder.Entity<BpmRole1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKMultipleOptions");

            entity.ToTable("BpmRole", "Process");

            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(45)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bpmrole>(entity =>
        {
            entity.ToTable("BPMRole", "Catalog");

            entity.HasIndex(e => e.Name, "UQ__BPMRole__737584F68059B10D").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BusinessGroup>(entity =>
        {
            entity.ToTable("BusinessGroup", "Catalog");

            entity.HasIndex(e => e.RsaKey, "UQ__Business__D1568DFAAE9EDB73").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.RsaKey)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("RSA_Key");
        });

        modelBuilder.Entity<BusinessProcess>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKBusinessProcess");

            entity.ToTable("BusinessProcess", "Process");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BusinessProcessRole>(entity =>
        {
            entity.HasKey(e => new { e.BpmRoleId, e.BusinessProcessId });

            entity.ToTable("BusinessProcessRoles", "Process");

            entity.HasOne(d => d.BpmRole).WithMany(p => p.BusinessProcessRoles)
                .HasForeignKey(d => d.BpmRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BusinessProcessRoles_BpmRole");

            entity.HasOne(d => d.BusinessProcess).WithMany(p => p.BusinessProcessRoles)
                .HasForeignKey(d => d.BusinessProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BusinessProcessRoles_BusinessProcess");
        });

        modelBuilder.Entity<Capture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKCaptures");

            entity.ToTable("Capture", "InstitutionalReport");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Tooltip)
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.DataType).WithMany(p => p.Captures)
                .HasForeignKey(d => d.DataTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKCapture_DataType");
        });

        modelBuilder.Entity<CaptureManualInfo>(entity =>
        {
            entity.HasKey(e => new { e.CaptureId, e.ManualInfoId }).HasName("PKCaptureManualInfo");

            entity.ToTable("CaptureManualInfo", "InstitutionalReport");

            entity.HasOne(d => d.Capture).WithMany(p => p.CaptureManualInfos)
                .HasForeignKey(d => d.CaptureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKCaptureManualInfo_Capture");

            entity.HasOne(d => d.ManualInfo).WithMany(p => p.CaptureManualInfos)
                .HasForeignKey(d => d.ManualInfoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKCaptureManualInfo_ManualInfoMetadata");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKCategory");

            entity.ToTable("Category", "InstitutionalReport");

            entity.Property(e => e.CeferRisk)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DgaiKey)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CeferMetadatum>(entity =>
        {
            entity.ToTable("CeferMetadata", "Cefer");

            entity.HasOne(d => d.Sector).WithMany(p => p.CeferMetadata)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CeferMetadata_Sector");
        });

        modelBuilder.Entity<ComentariosReporteInstitucional>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ComentariosReporteInstitucional");

            entity.Property(e => e.Comentario)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Dgai)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Institucion)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.Rubro)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Configuracion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Configur__3214EC07C4050CC7");

            entity.ToTable("Configuracion", "Adm");

            entity.Property(e => e.Key).HasMaxLength(150);

            entity.HasOne(d => d.System).WithMany(p => p.Configuracions)
                .HasForeignKey(d => d.SystemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Configuracion_Subsistema");
        });

        modelBuilder.Entity<DataType>(entity =>
        {
            entity.ToTable("DataType", "InstitutionalReport");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Deadline>(entity =>
        {
            entity.ToTable("Deadline", "InstitutionalReport");

            entity.Property(e => e.Deadline1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Deadline");

            entity.HasOne(d => d.Period).WithMany(p => p.Deadlines)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Deadline_Period");
        });

        modelBuilder.Entity<DepartmentParticipant>(entity =>
        {
            entity.HasKey(e => new { e.InstitutionId, e.DepartmentId }).HasName("PK_DepartmentParticipation");

            entity.ToTable("DepartmentParticipant", "InstitutionalReport");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentParticipants)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentParticipation_Area");

            entity.HasOne(d => d.Institution).WithMany(p => p.DepartmentParticipants)
                .HasForeignKey(d => d.InstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DepartmentParticipation_Entity");
        });

        modelBuilder.Entity<DynamicRisksConfiguration>(entity =>
        {
            entity.HasKey(e => new { e.DepartmentId, e.RiskId, e.InstitutionId });

            entity.ToTable("DynamicRisksConfiguration", "Cefer");

            entity.HasOne(d => d.Department).WithMany(p => p.DynamicRisksConfigurations)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicRisksConfiguration_Area");

            entity.HasOne(d => d.Institution).WithMany(p => p.DynamicRisksConfigurations)
                .HasForeignKey(d => d.InstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicRisksConfiguration_Entity");

            entity.HasOne(d => d.Risk).WithMany(p => p.DynamicRisksConfigurations)
                .HasForeignKey(d => d.RiskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DynamicRisksConfiguration_InherentRisk");
        });

        modelBuilder.Entity<Entity>(entity =>
        {
            entity.ToTable("Entity", "Cefer");

            entity.Property(e => e.Casfim)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.BusinessGroup).WithMany(p => p.Entities)
                .HasForeignKey(d => d.BusinessGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Entity_BusinessGroup");
        });

        modelBuilder.Entity<EntityProcessRole>(entity =>
        {
            entity.HasKey(e => new { e.BpmRoleId, e.BusinessProcessId, e.EntityId, e.UserId, e.Department });

            entity.ToTable("EntityProcessRoles", "Process");

            entity.HasOne(d => d.Entity).WithMany(p => p.EntityProcessRoles)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntityProcessRoles_Entity");

            entity.HasOne(d => d.User).WithMany(p => p.EntityProcessRoles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntityProcessRoles_Usuario");

            entity.HasOne(d => d.BusinessProcessRole).WithMany(p => p.EntityProcessRoles)
                .HasForeignKey(d => new { d.BpmRoleId, d.BusinessProcessId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EntityProcessRoles_BusinessProcessRoles");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.ToTable("Event", "Cefer");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Event1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Event_1");

            entity.ToTable("Event");

            entity.Property(e => e.Description)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.Instance)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Provider)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
        });

        modelBuilder.Entity<Event2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Event_2");

            entity.ToTable("Event", "Tracing");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Instance)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(300)
                .IsUnicode(false);

            entity.HasOne(d => d.ActivityType).WithMany(p => p.Event2s)
                .HasForeignKey(d => d.ActivityTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_ActivityType");

            entity.HasOne(d => d.System).WithMany(p => p.Event2s)
                .HasForeignKey(d => d.SystemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_Subsystem");

            entity.HasOne(d => d.User).WithMany(p => p.Event2s)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Event_Usuario");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.ToTable("Evento", "Adm");

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");

            entity.HasOne(d => d.Subsistema).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.SubsistemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evento_ToSubsistema");
        });

        modelBuilder.Entity<ExpertAdjustmentLog>(entity =>
        {
            entity.ToTable("ExpertAdjustmentLog", "Cefer");

            entity.Property(e => e.ChangeDate).HasColumnType("datetime");
            entity.Property(e => e.Justification)
                .HasMaxLength(510)
                .IsUnicode(false);

            entity.HasOne(d => d.RiskRate).WithMany(p => p.ExpertAdjustmentLogs)
                .HasForeignKey(d => d.RiskRateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpertAdjustmentLog_RiskRate");

            entity.HasOne(d => d.User).WithMany(p => p.ExpertAdjustmentLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExpertAdjustmentLog_User");
        });

        modelBuilder.Entity<ExportedFile>(entity =>
        {
            entity.HasKey(e => e.ReportId);

            entity.ToTable("ExportedFile", "InstitutionalReport");

            entity.Property(e => e.ReportId).ValueGeneratedNever();
            entity.Property(e => e.Extension)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.MimeType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SharepointId)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.UploadedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.Report).WithOne(p => p.ExportedFile)
                .HasForeignKey<ExportedFile>(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExportedFile_Report");
        });

        modelBuilder.Entity<ExternalSource>(entity =>
        {
            entity.ToTable("ExternalSource", "Cefer");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.TableDescription)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ExternalSource)
                .HasForeignKey<ExternalSource>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ExternalSource_CeferMetadata");
        });

        modelBuilder.Entity<IndexScript>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("index_scripts");

            entity.Property(e => e.CreateIndexScript).HasColumnName("create_index_script");
            entity.Property(e => e.DatabaseName)
                .HasMaxLength(128)
                .HasColumnName("database_name");
            entity.Property(e => e.IndexName)
                .HasMaxLength(128)
                .HasColumnName("index_name");
            entity.Property(e => e.LastUserLookup)
                .HasColumnType("datetime")
                .HasColumnName("last_user_lookup");
            entity.Property(e => e.LastUserScan)
                .HasColumnType("datetime")
                .HasColumnName("last_user_scan");
            entity.Property(e => e.LastUserSeek)
                .HasColumnType("datetime")
                .HasColumnName("last_user_seek");
            entity.Property(e => e.TableName)
                .HasMaxLength(128)
                .HasColumnName("table_name");
            entity.Property(e => e.UserLookups).HasColumnName("user_lookups");
            entity.Property(e => e.UserScans).HasColumnName("user_scans");
            entity.Property(e => e.UserSeeks).HasColumnName("user_seeks");
            entity.Property(e => e.UserUpdates).HasColumnName("user_updates");
        });

        modelBuilder.Entity<Indicator>(entity =>
        {
            entity.ToTable("Indicator", "Cefer");

            entity.HasIndex(e => e.Prefix, "UQ__Indicato__1FB4799D745C7FF9").IsUnique();

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InherentRisk>(entity =>
        {
            entity.ToTable("InherentRisk", "Cefer");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NewPrefix)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<InherentRiskMetadatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InherentRiskMetadata", "Cefer");

            entity.HasOne(d => d.CeferMetadata).WithMany()
                .HasForeignKey(d => d.CeferMetadataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InherentRiskMetadata_CeferMetadata");

            entity.HasOne(d => d.InherentRisk).WithMany()
                .HasForeignKey(d => d.InherentRiskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InherentRiskMetadata_InherentRisk");
        });

        modelBuilder.Entity<InstitutionCategoriesResponsible>(entity =>
        {
            entity.HasKey(e => new { e.InstitutionId, e.SectorVersionId, e.CategoryId, e.BpmRoleId, e.UserId });

            entity.ToTable("InstitutionCategoriesResponsibles", "InstitutionalReport");

            entity.HasOne(d => d.BpmRole).WithMany(p => p.InstitutionCategoriesResponsibles)
                .HasForeignKey(d => d.BpmRoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InstitutionCategoriesResponsibles_BpmRole");

            entity.HasOne(d => d.Institution).WithMany(p => p.InstitutionCategoriesResponsibles)
                .HasForeignKey(d => d.InstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InstitutionCategoriesResponsibles_Entity");

            entity.HasOne(d => d.User).WithMany(p => p.InstitutionCategoriesResponsibles)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InstitutionCategoriesResponsibles_Usuario");

            entity.HasOne(d => d.SectorVersionCategory).WithMany(p => p.InstitutionCategoriesResponsibles)
                .HasForeignKey(d => new { d.SectorVersionId, d.CategoryId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_InstitutionCategoriesResponsibles_SectorVersionCategory");
        });

        modelBuilder.Entity<LastPeriod>(entity =>
        {
            entity.HasKey(e => new { e.PeriodId, e.ForBanks }).HasName("PK_CeferLastPeriod");

            entity.ToTable("LastPeriod", "Cefer");
        });

        modelBuilder.Entity<ManagedFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKManagedFiles");

            entity.ToTable("ManagedFiles", "InstitutionalReport");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Extension)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.MimeType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SharepointId)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Entity).WithMany(p => p.ManagedFiles)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManagedFiles_Entity");

            entity.HasOne(d => d.Period).WithMany(p => p.ManagedFiles)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManagedFiles_Period");

            entity.HasOne(d => d.Sector).WithMany(p => p.ManagedFiles)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ManagedFiles_Sector");
        });

        modelBuilder.Entity<ManualInfoMetadatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKManualInfoMetadata");

            entity.ToTable("ManualInfoMetadata", "InstitutionalReport");

            entity.HasOne(d => d.AreaSpeciality).WithMany(p => p.ManualInfoMetadata)
                .HasForeignKey(d => new { d.AreaId, d.SpecialityId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKManualInfo_AreaSpecialities");
        });

        modelBuilder.Entity<Matrix>(entity =>
        {
            entity.ToTable("Matrix", "Cefer", tb => tb.HasTrigger("trg_t1"));

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Justification)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.ScoreTotal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.CeferMetadata).WithMany(p => p.Matrices)
                .HasForeignKey(d => d.CeferMetadataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Matrix_CeferMetadata");

            entity.HasOne(d => d.Entity).WithMany(p => p.Matrices)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Matrix_Entity");

            entity.HasOne(d => d.MatrixType).WithMany(p => p.Matrices)
                .HasForeignKey(d => d.MatrixTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Matrix_MatrixType");

            entity.HasOne(d => d.Period).WithMany(p => p.Matrices)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Matrix_Period");

            entity.HasOne(d => d.RateStatus).WithMany(p => p.Matrices)
                .HasForeignKey(d => d.RateStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Matrix_RateStatus");
        });

        modelBuilder.Entity<MatrixFile>(entity =>
        {
            entity.ToTable("MatrixFiles", "Cefer");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Extension)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MimeType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SharepointId).IsUnicode(false);

            entity.HasOne(d => d.Area).WithMany(p => p.MatrixFiles)
                .HasForeignKey(d => d.AreaId)
                .HasConstraintName("FK_MatrixFiles_Area");

            entity.HasOne(d => d.Matrix).WithMany(p => p.MatrixFiles)
                .HasForeignKey(d => d.MatrixId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatrixFiles_Matrix");
        });

        modelBuilder.Entity<MatrixParticipant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MatrixParticipant", "Cefer");

            entity.HasOne(d => d.Area).WithMany()
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatrixParticipant_Area");

            entity.HasOne(d => d.Entity).WithMany()
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatrixParticipant_Entity");

            entity.HasOne(d => d.Role).WithMany()
                .HasForeignKey(d => d.RoleId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatrixParticipant_BPMRole");

            entity.HasOne(d => d.User).WithMany()
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatrixParticipant_User");
        });

        modelBuilder.Entity<MatrixSetupInstance>(entity =>
        {
            entity.ToTable("MatrixSetupInstances", "Cefer");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.ProcessInstanceId)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Entity).WithMany(p => p.MatrixSetupInstances)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatrixSetupInstances_Entity");

            entity.HasOne(d => d.Period).WithMany(p => p.MatrixSetupInstances)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MatrixSetupInstances_Period");
        });

        modelBuilder.Entity<MatrixType>(entity =>
        {
            entity.ToTable("MatrixType", "Cefer");

            entity.HasIndex(e => e.Name, "UQ__MatrixTy__737584F67FAAF7CF").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Mitigating>(entity =>
        {
            entity.ToTable("Mitigating", "Cefer");

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MitigatingMetadatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MitigatingMetadata", "Cefer");

            entity.HasOne(d => d.CeferMetadata).WithMany()
                .HasForeignKey(d => d.CeferMetadataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MitigatingMetadata_CeferMetadata");

            entity.HasOne(d => d.Mitigating).WithMany()
                .HasForeignKey(d => d.MitigatingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MitigatingMetadata_Mitigating");
        });

        modelBuilder.Entity<MitigatingRate>(entity =>
        {
            entity.ToTable("MitigatingRate", "Cefer");

            entity.Property(e => e.Justification)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Notch)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.Mitigating).WithMany(p => p.MitigatingRates)
                .HasForeignKey(d => d.MitigatingId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MitigatingRate_Mitigating");

            entity.HasOne(d => d.RiskRate).WithMany(p => p.MitigatingRates)
                .HasForeignKey(d => d.RiskRateId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MitigatingRate_RiskRate");
        });

        modelBuilder.Entity<MultipleOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKMultipleOptions");

            entity.ToTable("MultipleOption", "InstitutionalReport");

            entity.Property(e => e.MultipleValue)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Capture).WithMany(p => p.MultipleOptions)
                .HasForeignKey(d => d.CaptureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKMultipleOptions_Capture");
        });

        modelBuilder.Entity<Notch>(entity =>
        {
            entity.ToTable("Notch", "Cefer");

            entity.Property(e => e.FinalNotch)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FinalRange).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.InherentRiskPercentage).HasColumnType("numeric(18, 2)");
            entity.Property(e => e.InitialRange).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.MitigatingPercentage).HasColumnType("numeric(18, 2)");
        });

        modelBuilder.Entity<PageAccess>(entity =>
        {
            entity.ToTable("PageAccess");

            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.Url)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Period>(entity =>
        {
            entity.ToTable("Period", "Cefer");

            entity.HasIndex(e => e.Value, "uc_Value").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Value)
                .HasMaxLength(6)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.ToTable("Position", "Process");

            entity.Property(e => e.BpmName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.GuidKey)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Area).WithMany(p => p.Positions)
                .HasForeignKey(d => d.AreaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Position_Area");

            entity.HasOne(d => d.SubSystem).WithMany(p => p.Positions)
                .HasForeignKey(d => d.SubSystemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Position_Subsystem");
        });

        modelBuilder.Entity<ProcessInstance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKProcessInstance");

            entity.ToTable("ProcessInstance", "Process");

            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BusinessProcess).WithMany(p => p.ProcessInstances)
                .HasForeignKey(d => d.BusinessProcessId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKProcessInstanceBusinessProcess");

            entity.HasOne(d => d.Entity).WithMany(p => p.ProcessInstances)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKProcessInstanceEntity");

            entity.HasOne(d => d.Period).WithMany(p => p.ProcessInstances)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKProcessInstancePeriod");
        });

        modelBuilder.Entity<RateStatus>(entity =>
        {
            entity.ToTable("RateStatus", "Cefer");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Report>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKReport");

            entity.ToTable("Report", "InstitutionalReport");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.Entity).WithMany(p => p.Reports)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKReportEntity");

            entity.HasOne(d => d.Period).WithMany(p => p.Reports)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKReportPeriod");

            entity.HasOne(d => d.Status).WithMany(p => p.Reports)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKReportStatus");
        });

        modelBuilder.Entity<ReportCapture>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKReportCaptures");

            entity.ToTable("ReportCaptures", "InstitutionalReport");

            entity.Property(e => e.CaptureValue).IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.Report).WithMany(p => p.ReportCaptures)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKReportCaptures_Report");

            entity.HasOne(d => d.CaptureManualInfo).WithMany(p => p.ReportCaptures)
                .HasForeignKey(d => new { d.CapturesId, d.ManualInfoId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKReportCaptures_CapturesManualInfoMetadata_Captures");
        });

        modelBuilder.Entity<ReportCategory>(entity =>
        {
            entity.ToTable("ReportCategory", "InstitutionalReport");

            entity.Property(e => e.CeferScore)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Comment).IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.Report).WithMany(p => p.ReportCategories)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportCategory_Report");

            entity.HasOne(d => d.SectorVersionCategory).WithMany(p => p.ReportCategories)
                .HasForeignKey(d => new { d.SectorVersionId, d.CategoryId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportCategory_SectorVersionCategory");
        });

        modelBuilder.Entity<ReportUpdate>(entity =>
        {
            entity.ToTable("ReportUpdate", "InstitutionalReport");

            entity.Property(e => e.EstablishedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");

            entity.HasOne(d => d.Report).WithMany(p => p.ReportUpdates)
                .HasForeignKey(d => d.ReportId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReportUpdate_Report");
        });

        modelBuilder.Entity<RiskIndicatorMetadatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RiskIndicatorMetadata", "Cefer");

            entity.HasOne(d => d.CeferMetadata).WithMany()
                .HasForeignKey(d => d.CeferMetadataId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskIndicatorMetadata_CeferMetadata");

            entity.HasOne(d => d.Indicator).WithMany()
                .HasForeignKey(d => d.IndicatorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskIndicatorMetadata_Indicator");

            entity.HasOne(d => d.InherentRisk).WithMany()
                .HasForeignKey(d => d.InherentRiskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskIndicatorMetadata_InherentRisk");
        });

        modelBuilder.Entity<RiskProperty>(entity =>
        {
            entity.ToTable("RiskProperty", "Cefer");

            entity.HasIndex(e => e.Name, "UQ__RiskProp__737584F6218C40D9").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RiskPropertyMetadatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RiskPropertyMetadata", "Cefer");

            entity.HasOne(d => d.InherentRisk).WithMany()
                .HasForeignKey(d => d.InherentRiskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskPropertyMetadata_InherentRisk");

            entity.HasOne(d => d.RiskProperty).WithMany()
                .HasForeignKey(d => d.RiskPropertyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskPropertyMetadata_RiskProperty");
        });

        modelBuilder.Entity<RiskRate>(entity =>
        {
            entity.ToTable("RiskRate", "Cefer");

            entity.Property(e => e.AdjustedInherentRisk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.InherentRisk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Justification)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.MitigatingScoreTotal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NetRisk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.InherentRiskNavigation).WithMany(p => p.RiskRates)
                .HasForeignKey(d => d.InherentRiskId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskRate_InherentRisk");

            entity.HasOne(d => d.Matrix).WithMany(p => p.RiskRates)
                .HasForeignKey(d => d.MatrixId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RiskRate_Matrix");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Role__3214EC071C5D900C");

            entity.ToTable("Role", "Adm");

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaActualizacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);

            entity.HasOne(d => d.Subsistema).WithMany(p => p.Roles)
                .HasForeignKey(d => d.SubsistemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Role_ToSubsistema");

            entity.HasMany(d => d.Actividads).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "ActividadRole",
                    r => r.HasOne<Actividad>().WithMany()
                        .HasForeignKey("ActividadId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ActividadRole_ToActividad"),
                    l => l.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ActividadRole_ToRole"),
                    j =>
                    {
                        j.HasKey("RoleId", "ActividadId");
                        j.ToTable("ActividadRole", "Adm");
                    });

            entity.HasMany(d => d.Usuarios).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioRol",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsuarioRol_ToUsuario"),
                    l => l.HasOne<Role>().WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsuarioRol_ToRole"),
                    j =>
                    {
                        j.HasKey("RoleId", "UsuarioId");
                        j.ToTable("UsuarioRol", "Adm");
                    });
        });

        modelBuilder.Entity<Sector>(entity =>
        {
            entity.ToTable("Sector", "Cefer");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SectorVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKSectorVersion");

            entity.ToTable("SectorVersion", "InstitutionalReport");

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Sector).WithMany(p => p.SectorVersions)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKSectorVersionSector");

            entity.HasMany(d => d.ManualInfos).WithMany(p => p.SectorVersions)
                .UsingEntity<Dictionary<string, object>>(
                    "SectorVersionManualInfo",
                    r => r.HasOne<ManualInfoMetadatum>().WithMany()
                        .HasForeignKey("ManualInfoId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FKSectorVersionManualInfo_ManualInfo"),
                    l => l.HasOne<SectorVersion>().WithMany()
                        .HasForeignKey("SectorVersionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FKSectorVersionManualInfo_SectorVersion"),
                    j =>
                    {
                        j.HasKey("SectorVersionId", "ManualInfoId").HasName("PKSectorVersionManualInfo");
                        j.ToTable("SectorVersionManualInfo", "InstitutionalReport");
                    });
        });

        modelBuilder.Entity<SectorVersionCategory>(entity =>
        {
            entity.HasKey(e => new { e.SectorVersionId, e.CategoryId }).HasName("PKSectorVersionCategory");

            entity.ToTable("SectorVersionCategory", "InstitutionalReport");

            entity.HasOne(d => d.Category).WithMany(p => p.SectorVersionCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKSectorVersionCategoryCategory");

            entity.HasOne(d => d.SectorVersion).WithMany(p => p.SectorVersionCategories)
                .HasForeignKey(d => d.SectorVersionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKSectorVersionCategorySector");
        });

        modelBuilder.Entity<Speciality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PKSpeciality");

            entity.ToTable("Speciality", "InstitutionalReport");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Prefix)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Notch");

            entity.ToTable("Status", "InstitutionalReport");

            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<StoredFile>(entity =>
        {
            entity.HasKey(e => new { e.SharepointId, e.InstitutionId, e.PeriodId });

            entity.ToTable("StoredFiles", "Cefer");

            entity.Property(e => e.Extension)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MimeType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Score)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.UploadedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.Institution).WithMany(p => p.StoredFiles)
                .HasForeignKey(d => d.InstitutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoredFiles_Entity");

            entity.HasOne(d => d.Period).WithMany(p => p.StoredFiles)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StoredFiles_Period");
        });

        modelBuilder.Entity<Subsistema>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Subsiste__3214EC0748871217");

            entity.ToTable("Subsistema", "Adm");

            entity.Property(e => e.Descripcion).HasMaxLength(500);
            entity.Property(e => e.FechaActualizacion).HasColumnType("datetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.NombreSistema).HasMaxLength(50);
        });

        modelBuilder.Entity<Subsystem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Subsystems");

            entity.ToTable("Subsystem", "Catalog");

            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasMany(d => d.Sectors).WithMany(p => p.Subsystems)
                .UsingEntity<Dictionary<string, object>>(
                    "AvailableSector",
                    r => r.HasOne<Sector>().WithMany()
                        .HasForeignKey("SectorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AvailableSector_Sector"),
                    l => l.HasOne<Subsystem>().WithMany()
                        .HasForeignKey("SubsystemId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_AvailableSector_Subsystem"),
                    j =>
                    {
                        j.HasKey("SubsystemId", "SectorId");
                        j.ToTable("AvailableSector", "Catalog");
                    });
        });

        modelBuilder.Entity<SystemicInstitution>(entity =>
        {
            entity.ToTable("SystemicInstitution", "Catalog");

            entity.HasOne(d => d.Entity).WithMany(p => p.SystemicInstitutions)
                .HasForeignKey(d => d.EntityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SystemicInstitution_Entity");
        });

        modelBuilder.Entity<TipoEvento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TipoEven__3214EC0717FCAE97");

            entity.ToTable("TipoEvento", "Adm");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Subsistema).WithMany(p => p.TipoEventos)
                .HasForeignKey(d => d.SubsistemaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TipoEvento_ToSubsistema");
        });

        modelBuilder.Entity<Trace>(entity =>
        {
            entity.Property(e => e.FormattedMessage).HasMaxLength(4000);
            entity.Property(e => e.InstanceName).HasMaxLength(1000);
            entity.Property(e => e.Payload).HasMaxLength(4000);
            entity.Property(e => e.ProviderName).HasMaxLength(500);
        });

        modelBuilder.Entity<UnmanagedSector>(entity =>
        {
            entity.HasKey(e => e.SectorId);

            entity.ToTable("UnmanagedSector", "Catalog");

            entity.Property(e => e.SectorId).ValueGeneratedNever();

            entity.HasOne(d => d.Sector).WithOne(p => p.UnmanagedSector)
                .HasForeignKey<UnmanagedSector>(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnmanagedSector_Sector");
        });

        modelBuilder.Entity<UnmanagedSectorFile>(entity =>
        {
            entity.HasKey(e => e.SharepointId);

            entity.ToTable("UnmanagedSectorFiles", "InstitutionalReport");

            entity.Property(e => e.SharepointId).ValueGeneratedNever();
            entity.Property(e => e.Extension)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.MimeType)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Size).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UploadDate).HasColumnType("datetime");
            entity.Property(e => e.UploadedBy)
                .HasMaxLength(8)
                .IsUnicode(false);

            entity.HasOne(d => d.Period).WithMany(p => p.UnmanagedSectorFiles)
                .HasForeignKey(d => d.PeriodId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnmanagedSectorFiles_Period");

            entity.HasOne(d => d.Sector).WithMany(p => p.UnmanagedSectorFiles)
                .HasForeignKey(d => d.SectorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UnmanagedSectorFiles_UnmanagedSector");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC07F4D9E4CB");

            entity.ToTable("Usuario", "Adm");

            entity.Property(e => e.Alias)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Expediente)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.FechaActualizacion).HasColumnType("smalldatetime");
            entity.Property(e => e.FechaRegistro).HasColumnType("smalldatetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(120)
                .IsUnicode(false);

            entity.HasMany(d => d.Areas).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "UsersArea",
                    r => r.HasOne<Area>().WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsersAreas_Area"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_UsersAreas_Usuario"),
                    j =>
                    {
                        j.HasKey("UserId", "AreaId");
                        j.ToTable("UsersAreas", "Catalog");
                    });
        });

        modelBuilder.Entity<VwMatrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_Matrices", "Cefer");

            entity.Property(e => e.Casfim)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Justification)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Period)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ScoreTotal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMatrixFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MatrixFiles", "Cefer");

            entity.Property(e => e.Casfim)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Department)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Extension)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.MimeType)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Period)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SharepointId).IsUnicode(false);
        });

        modelBuilder.Entity<VwMatrixMitigatingRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MatrixMitigatingRate", "Cefer");

            entity.Property(e => e.Casfim)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InherentRisk)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Justification)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Notch)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Periodo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMatrixParticipant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MatrixParticipant", "Cefer");

            entity.Property(e => e.Casfim)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.User)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMatrixProcessInstance>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MatrixProcessInstances", "Cefer");

            entity.Property(e => e.Casfim)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.Period)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ProcessInstanceId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMatrixRiskConfiguration>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MatrixRiskConfiguration", "Cefer");

            entity.Property(e => e.Casfim)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Department)
                .HasMaxLength(7)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VwMatrixRiskRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vw_MatrixRiskRates", "Cefer");

            entity.Property(e => e.AdjustedInherentRisk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Casfim)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.InherentRisk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Justification)
                .HasMaxLength(510)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.MitigatingScoreTotal)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NetRisk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Periodo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
