class EmailValidator:
    def __init__(self, min_length, mails, domains):
        self.min_length = min_length
        self.mails = mails
        self.domains = domains

    def __is_name_valid(self, name):
        if len(name) >= self.min_length:
            return True
        return False

    def __is_mail_valid(self, mail):
        if mail in self.mails:
            return True
        return False

    def __is_domain_valid(self, domain):
        if domain in self.domains:
            return True
        return False

    def validate(self, email):
        name = email.split("@")
        mail = name[1].split(".")
        if self.min_length <= len(name[0]) and mail[0] in self.mails and mail[1] in self.domains:
            return True
        return False


mails = ["gmail", "softuni"]
domains = ["com", "bg"]
email_validator = EmailValidator(6, mails, domains)
print(email_validator.validate("pe77er@gmail.com"))
print(email_validator.validate("georgios@gmail.net"))
print(email_validator.validate("stamatito@abv.net"))
print(email_validator.validate("abv@softuni.bg"))

