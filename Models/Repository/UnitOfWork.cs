using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Models.Repository
{
    public partial class UnitOfWork : IDisposable
    {
        private ModelDb context;//= new ModelDb();

        public UnitOfWork()
        {
            this.context = ModelDb.Create(DataSource);
        }
        public static string DataSource;
        private GenericRepository<Veterinaries> _VeterinariesRepo;
        public GenericRepository<Veterinaries> VeterinariesRepo
        {
            get
            {
                if (this._VeterinariesRepo == null)
                    this._VeterinariesRepo = new GenericRepository<Veterinaries>(context);
                return _VeterinariesRepo;
            }
            set { _VeterinariesRepo = value; }
        }
        private GenericRepository<ConfinementRecords> _ConfinementRecordsRepo;
        public GenericRepository<ConfinementRecords> ConfinementRecordsRepo
        {
            get
            {
                if (this._ConfinementRecordsRepo == null)
                    this._ConfinementRecordsRepo = new GenericRepository<ConfinementRecords>(context);
                return _ConfinementRecordsRepo;
            }
            set { _ConfinementRecordsRepo = value; }
        }

        private GenericRepository<Owners> _OwnersRepo;
        public GenericRepository<Owners> OwnersRepo
        {
            get
            {
                if (this._OwnersRepo == null)
                    this._OwnersRepo = new GenericRepository<Owners>(context);
                return _OwnersRepo;
            }
            set { _OwnersRepo = value; }
        }
        private GenericRepository<Patients> _PatientsRepo;
        public GenericRepository<Patients> PatientsRepo
        {
            get
            {
                if (this._PatientsRepo == null)
                    this._PatientsRepo = new GenericRepository<Patients>(context);
                return _PatientsRepo;
            }
            set { _PatientsRepo = value; }
        }

        private GenericRepository<Logs> _LogsRepo;
        public GenericRepository<Logs> LogsRepo
        {
            get
            {
                if (this._LogsRepo == null)
                    this._LogsRepo = new GenericRepository<Logs>(context);
                return _LogsRepo;
            }
            set { _LogsRepo = value; }
        }

        private GenericRepository<Actions> _ActionsRepo;
        public GenericRepository<Actions> ActionsRepo
        {
            get
            {
                if (this._ActionsRepo == null)
                    this._ActionsRepo = new GenericRepository<Actions>(context);
                return _ActionsRepo;
            }
            set { _ActionsRepo = value; }
        }

        private GenericRepository<UserRolesInActions> _UserRolesInActionsRepo;
        public GenericRepository<UserRolesInActions> UserRolesInActionsRepo
        {
            get
            {
                if (this._UserRolesInActionsRepo == null)
                    this._UserRolesInActionsRepo = new GenericRepository<UserRolesInActions>(context);
                return _UserRolesInActionsRepo;
            }
            set { _UserRolesInActionsRepo = value; }
        }


        private GenericRepository<ControllersActions> _ControllersActionsRepo;
        public GenericRepository<ControllersActions> ControllersActionsRepo
        {
            get
            {
                if (this._ControllersActionsRepo == null)
                    this._ControllersActionsRepo = new GenericRepository<ControllersActions>(context);
                return _ControllersActionsRepo;
            }
            set { _ControllersActionsRepo = value; }
        }



        private GenericRepository<Users> usersRepo;
        public GenericRepository<Users> UsersRepo
        {
            get
            {
                if (this.usersRepo == null)
                    this.usersRepo = new GenericRepository<Users>(context);
                return usersRepo;
            }
            set { usersRepo = value; }
        }

        private GenericRepository<UserRoles> userRolesRepo;
        public GenericRepository<UserRoles> UserRolesRepo
        {
            get
            {
                if (this.userRolesRepo == null)
                    this.userRolesRepo = new GenericRepository<UserRoles>(context);
                return userRolesRepo;
            }
            set { userRolesRepo = value; }
        }




        public void Save()
        {
            context.SaveChanges();

        }


        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }

}