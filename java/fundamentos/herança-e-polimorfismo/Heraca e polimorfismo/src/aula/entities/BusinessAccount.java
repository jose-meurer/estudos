package aula.entities;

public class BusinessAccount extends Account{

    private Double loanLimit;

    public BusinessAccount() {
    }

    public BusinessAccount(Integer number, String holder, Double balance, Double loanLimit) {
        super(number, holder, balance);
        this.loanLimit = loanLimit;
    }

    public Double getLoanLimit() {
        return loanLimit;
    }

    public void setLoanLimit(Double loanLimit) {
        this.loanLimit = loanLimit;
    }

    public void loan(Double amount) {
        if(amount > loanLimit) {
            return;
        }

        balance += amount - 10;
    }

    @Override
    public String toString() {
        return "BusinessAccount{" +
                "number=" + number +
                ", holder='" + holder + '\'' +
                ", balance=" + balance +
                ", loanLimit=" + loanLimit +
                '}';
    }
}
