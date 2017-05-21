package model;
// Generated May 21, 2017 1:57:04 PM by Hibernate Tools 5.2.1.Final

import java.util.Date;
import java.util.HashSet;
import java.util.Set;

/**
 * Branch generated by hbm2java
 */
public class Branch implements java.io.Serializable {

	private Integer idBranch;
	private Owner owner;
	private String name;
	private String address;
	private String phone;
	private String fax;
	private Integer createdBy;
	private Integer lastUpdateBy;
	private Date createdDate;
	private Date lastUpdateDate;
	private Set transactionses = new HashSet(0);
	private Set employees = new HashSet(0);
	private Set accounts = new HashSet(0);
	private Set savingsAccounts = new HashSet(0);
	private Set customers = new HashSet(0);

	public Branch() {
	}

	public Branch(Owner owner) {
		this.owner = owner;
	}

	public Branch(Owner owner, String name, String address, String phone, String fax, Integer createdBy,
			Integer lastUpdateBy, Date createdDate, Date lastUpdateDate, Set transactionses, Set employees,
			Set accounts, Set savingsAccounts, Set customers) {
		this.owner = owner;
		this.name = name;
		this.address = address;
		this.phone = phone;
		this.fax = fax;
		this.createdBy = createdBy;
		this.lastUpdateBy = lastUpdateBy;
		this.createdDate = createdDate;
		this.lastUpdateDate = lastUpdateDate;
		this.transactionses = transactionses;
		this.employees = employees;
		this.accounts = accounts;
		this.savingsAccounts = savingsAccounts;
		this.customers = customers;
	}

	public Integer getIdBranch() {
		return this.idBranch;
	}

	public void setIdBranch(Integer idBranch) {
		this.idBranch = idBranch;
	}

	public Owner getOwner() {
		return this.owner;
	}

	public void setOwner(Owner owner) {
		this.owner = owner;
	}

	public String getName() {
		return this.name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getAddress() {
		return this.address;
	}

	public void setAddress(String address) {
		this.address = address;
	}

	public String getPhone() {
		return this.phone;
	}

	public void setPhone(String phone) {
		this.phone = phone;
	}

	public String getFax() {
		return this.fax;
	}

	public void setFax(String fax) {
		this.fax = fax;
	}

	public Integer getCreatedBy() {
		return this.createdBy;
	}

	public void setCreatedBy(Integer createdBy) {
		this.createdBy = createdBy;
	}

	public Integer getLastUpdateBy() {
		return this.lastUpdateBy;
	}

	public void setLastUpdateBy(Integer lastUpdateBy) {
		this.lastUpdateBy = lastUpdateBy;
	}

	public Date getCreatedDate() {
		return this.createdDate;
	}

	public void setCreatedDate(Date createdDate) {
		this.createdDate = createdDate;
	}

	public Date getLastUpdateDate() {
		return this.lastUpdateDate;
	}

	public void setLastUpdateDate(Date lastUpdateDate) {
		this.lastUpdateDate = lastUpdateDate;
	}

	public Set getTransactionses() {
		return this.transactionses;
	}

	public void setTransactionses(Set transactionses) {
		this.transactionses = transactionses;
	}

	public Set getEmployees() {
		return this.employees;
	}

	public void setEmployees(Set employees) {
		this.employees = employees;
	}

	public Set getAccounts() {
		return this.accounts;
	}

	public void setAccounts(Set accounts) {
		this.accounts = accounts;
	}

	public Set getSavingsAccounts() {
		return this.savingsAccounts;
	}

	public void setSavingsAccounts(Set savingsAccounts) {
		this.savingsAccounts = savingsAccounts;
	}

	public Set getCustomers() {
		return this.customers;
	}

	public void setCustomers(Set customers) {
		this.customers = customers;
	}

}
