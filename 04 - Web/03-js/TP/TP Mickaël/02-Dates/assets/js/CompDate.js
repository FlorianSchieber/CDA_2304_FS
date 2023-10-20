class CompDate
{
    constructor(_date)
    {
        this.dateAujourdhui = new Date();
        this.dateNaissance = _date;
    }

    anneesEntreDates()
    {
        let differenceMs;
        differenceMs = this.dateAujourdhui - this.dateNaissance;
        let differenceJours = differenceMs / (1000 * 60 * 60 * 365);
        return differenceJours;
    }

}

export { CompDate };