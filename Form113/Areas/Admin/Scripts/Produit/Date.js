
$(function () {
    $("#DateMiseEnVente").datepicker(
            {
                format: "dd/mm/yyyy",
                todayBtn: "linked",
                language: "fr",
                autoClose: true,
                todayHighlight: true,
                startDate: new Date()
            });
})