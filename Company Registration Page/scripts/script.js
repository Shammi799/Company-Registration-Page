$(document).ready(function() {
    $("#companyRegistrationForm").validate({
        rules: {
            companyName: "required",
            contactPerson: "required",
            email: {
                required: true,
                email: true
            },
            phone: {
                required: true,
                digits: true,
                minlength: 10
            },
            password: "required",
            retypePassword: {
                equalTo: "#password"
            },
            declaration: "required"
        },
        messages: {
            companyName: "Please enter your company name",
            contactPerson: "Please enter a contact person",
            email: "Please enter a valid email",
            phone: "Please enter a valid phone number",
            password: "Please enter a password",
            retypePassword: "Passwords must match",
            declaration: "You must agree to the declaration"
        }
    });
});
