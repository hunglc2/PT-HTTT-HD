package model;
// Generated May 21, 2017 1:57:04 PM by Hibernate Tools 5.2.1.Final

import java.util.Date;
import java.util.HashSet;
import java.util.Set;

/**
 * AccountType generated by hbm2java
 */
public class AccountType implements java.io.Serializable {

	private Integer idAccountType;
	private String name;
	private Long minBal;
	private Long maxBal;
	private String status;
	private Integer createdBy;
	private Integer lastUpdateBy;
	private Date createDate;
	private Date lastUpdateDate;
	private Set accounts = new HashSet(0);

	public AccountType() {
	}

	public AccountType(String name, Long minBal, Long maxBal, String status, Integer createdBy, Integer lastUpdateBy,
			Date createDate, Date lastUpdateDate, Set accounts) {
		this.name = name;
		this.minBal = minBal;
		this.maxBal = maxBal;
		this.status = status;
		this.createdBy = createdBy;
		this.lastUpdateBy = lastUpdateBy;
		this.createDate = createDate;
		this.lastUpdateDate = lastUpdateDate;
		this.accounts = accounts;
	}

	public Integer getIdAccountType() {
		return this.idAccountType;
	}

	public void setIdAccountType(Integer idAccountType) {
		this.idAccountType = idAccountType;
	}

	public String getName() {
		return this.name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public Long getMinBal() {
		return this.minBal;
	}

	public void setMinBal(Long minBal) {
		this.minBal = minBal;
	}

	public Long getMaxBal() {
		return this.maxBal;
	}

	public void setMaxBal(Long maxBal) {
		this.maxBal = maxBal;
	}

	public String getStatus() {
		return this.status;
	}

	public void setStatus(String status) {
		this.status = status;
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

	public Date getCreateDate() {
		return this.createDate;
	}

	public void setCreateDate(Date createDate) {
		this.createDate = createDate;
	}

	public Date getLastUpdateDate() {
		return this.lastUpdateDate;
	}

	public void setLastUpdateDate(Date lastUpdateDate) {
		this.lastUpdateDate = lastUpdateDate;
	}

	public Set getAccounts() {
		return this.accounts;
	}

	public void setAccounts(Set accounts) {
		this.accounts = accounts;
	}

}
